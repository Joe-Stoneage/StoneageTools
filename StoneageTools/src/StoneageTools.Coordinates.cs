
using StoneageTools.Coordinatesbase;

namespace StoneageTools.Coordinates
{
    public class StoneageCoordinates
    {
        private readonly EllipsoidBase ellipsoidBase = new();
        /*
        N: Nord = latitude 0 ..  90, S = 0 ..  -90, phi
        E: Ost = longitude 0 .. 180, W = 0 .. -180, lambda
        grundsätzlich: (lat xx, lon yyy) nie umgekehrt, lat=2-stellig, lon=3-stellig
        grundsätzlich: Koordinaten werden immer mit "." geschrieben, in allen Sprachen, nie mit ","

        System Name           Format 1         Format 2                Format 3                                        Meaning                                 Remark
        DMS   Sexagesimal     ddd mm ss.ss     DDD° MM' SS.SS"         [N/S] DD° MM' SS.SSS? [E/W] DDD° MM' SS.SSS"    Grad Minute Sekunde . Zehntelsekunde
        DMM   Nautisch / GPS  ddd mm.mmm       DDD° MM.MMM'            [N/S] DD° MM.MMMM' [E/W] DDD° MM.MMM’           Grad Minute . Zehntelminute             Geocaching, falsch: DEG/DEC!
        DDD   Dezimalgrad     ddd.ddddd        DDD.DDDD°               [N/S] DD.DDDD° [E/W] DDD.DDDD°                  Grad . Zehntelgrad                      Google LAT LON
        D/d  steht für Degree (Grad), M/m für Minute und S/s für Sekunde, h für Heading (Richtung, Prefix)
        Die letzte Einheit kann immer auch als Zehntelwert/Dezimale vorkommen
        */
        /* $ [N/E/S/W][-][D]DD.DDDD[°] -> $[N/E/S/W][D]DD° MM.MMM' */
        public string DDD_2_DMM(string coord)
        {
            string retval = "ERROR";
            const string directions ="NSEW";
            char direction = ' ';
            const char grad = '°';
            char test;
            double vorkomma;
            double nachkomma;

            if (!String.IsNullOrWhiteSpace(coord))
            {
                string cc = coord.Trim();
                int l = cc.Length;
                if (l > 3)                                                  /* Minimum: 0.1 */
                {
                    int t = directions.IndexOf(cc[0]);                      /* Himmelsrichtung an erster Stelle mitgegeben? */
                    if (t != -1)
                    {
                        direction = directions[t];
                        l--;
                        cc = cc.Substring(1,l);
                    }

                    test = cc[l-1];                                         /* Gradzeichen mitgegeben? */
                    {
                        if (test == grad)
                        {
                            l--;
                            cc = cc[..l];
                        }
                    }
                    t = cc.IndexOf(".");  if (t == -1) cc.IndexOf(",");     /* Kommaübergabe abfangen */
                    if (t > -1)
                    {
                        vorkomma = -1;
                        nachkomma = -1;
                        try
                        {   /* selbst Vor- und Nachkomma umwandeln, um Problemen mit Internationalisierung nicht zu bekommen */
                            vorkomma = Convert.ToInt32(cc[..t]);
                            cc = cc.Substring(t+1, l-t-1);
                            nachkomma = Convert.ToInt32(cc);
                            cc = nachkomma.ToString();
                            l = cc.Length;
                            cc = "100000000000000";
                            cc = cc[..(l + 1)];
                            l = Convert.ToInt32(cc);
                            nachkomma /= l;
                            /* Grad in Sekunden umwandeln */
                            nachkomma *= 60;
                            retval = "";
                            if (direction != ' ') retval=direction.ToString();
                            retval = retval + $"{vorkomma}" + "° " + $"{nachkomma}'";
                            retval = retval.Replace(',','.');
                        }
                        catch
                        {
                            retval = $"ERROR in Konvertierung Zeichenkette:{cc} {vorkomma} {nachkomma}'";
                        }
                    }
                    else
                    {
                        retval = "ERROR Länge passt nicht";
                    }
                }
            }
            return retval;
        }

        public string DMM_2_DMS(string coord)
        {
            string ret = string.Empty;
            return ret;
        }

        public string DMS_2_DMM(string coord)
        {
            string ret = string.Empty;
            return ret;
        }
        public string DMM_2_DDD(string coord)                    // entspricht Geocaching -> GoogleMaps
        {
            string ret = string.Empty;
            return ret;
        }

        public string Geocaching_2_GoogleMaps(string coord)      // Wrapper für DMM_2_DDD
        {
            return DMM_2_DDD(coord);
        }

        public string Geocaching_2_UTM(string coord)
        {
            string ret = string.Empty;
            return ret;
        }

        /* Die Entfernung zwischen zwei UTM-Koordinaten kann einfach über den Satz des Pythagoras (Formel für gleichwinkliges Dreieck) berechnet
           werden, WENN die Koordinaten nicht zu weit auseinanderliegen (möglichst in der gleichen UTM-Zone). Zurück kommt die Entfernung in Metern. */
        public double UTM_Distance(double norting1, double easting1, double norting2, double easting2)
        {
            return System.Math.Sqrt((norting1 * norting2) / (easting1 * easting2));
        }

        /* Wichtig: westliche Länge und südliche Breite negativ übergeben! */
        /* converts LatLong to UTM coords;  3/22/95: by ChuckGantz chuck.gantz@globalstar.com, from USGS Bulletin 1532.
        Lat and Long are in degrees;  North latitudes and East Longitudes are positive.
        PARAMETER
            int eId 		    der zu verwendende Elipsoid (siehe Ellipsoids.cs, Standard bei uns: 22 (WGS84))
            double Lat	        der Breitengrad (Nord ist positiv, Süd ist negativ)
            double Long	        der Längengrad (Ost ist positiv, West ist negativ)
            double& Northing	Rückgabe: UTM Nordwert
            double& Easting	    Rückgabe: UTM Ostwert
            int& Zone		    Rückgabe: UTM Zone */
        public void LL_2_UTM(
                                    int eId,
                                    double Lat,
                                    double Long,
                                    ref double Northing,
                                    ref double Easting,
                                    ref int Zone)
        {
            double deg2rad = System.Math.PI / 180;
            double k0 = 0.9996;
            eId = EllipsoidBase.EllipsoidCheckValid(eId);
            double a = ellipsoidBase.Ellipsoids[eId].EquatorialRadius;
            double ee = ellipsoidBase.Ellipsoids[eId].EccSquared;
            Long -= (int)((Long + 180) / 360) * 360;       //ensure longitude within -180.00..179.9
            double N, T, C, A, M;
            double LatRad = Lat * deg2rad;
            double LongRad = Long * deg2rad;

            Zone = (int)((Long + 186) / 6);
            if (Lat >= 56.0 && Lat < 64.0 && Long >= 3.0 && Long < 12.0)
                Zone = 32;

            if (Lat >= 72.0 && Lat < 84.0)                  //Special zones for Svalbard
            {
                if (Long >= 0.0 && Long < 9.0)
                    Zone = 31;
                else if (Long >= 9.0 && Long < 21.0)
                    Zone = 33;
                else if (Long >= 21.0 && Long < 33.0)
                    Zone = 35;
                else if (Long >= 33.0 && Long < 42.0)
                    Zone = 37;
            }
            double LongOrigin = Zone * 6 - 183;             //origin in middle of zone
            double LongOriginRad = LongOrigin * deg2rad;

            double EE = ee / (1 - ee);

            N = a / System.Math.Sqrt(1 - ee * System.Math.Sin(LatRad) * System.Math.Sin(LatRad));
            T = System.Math.Tan(LatRad) * System.Math.Tan(LatRad);
            C = EE * System.Math.Cos(LatRad) * System.Math.Cos(LatRad);
            A = System.Math.Cos(LatRad) * (LongRad - LongOriginRad);

            M = a * ((1 - ee / 4 - 3 * ee * ee / 64 - 5 * ee * ee * ee / 256) * LatRad
            - (3 * ee / 8 + 3 * ee * ee / 32 + 45 * ee * ee * ee / 1024) * System.Math.Sin(2 * LatRad)
            + (15 * ee * ee / 256 + 45 * ee * ee * ee / 1024) * System.Math.Sin(4 * LatRad)
            - (35 * ee * ee * ee / 3072) * System.Math.Sin(6 * LatRad));

            Easting =
            k0 * N * (A + (1 - T + C) * A * A * A / 6 + (5 - 18 * T + T * T + 72 * C - 58 * EE) * A * A * A * A * A / 120) + 500000.0;

            Northing = k0 * (M + N * System.Math.Tan(LatRad) * (A * A / 2 + (5 - T + 9 * C + 4 * C * C) * A * A * A * A / 24
                                + (61 - 58 * T + T * T + 600 * C - 330 * EE) * A * A * A * A * A * A / 720));
        }

        /* Wichtig: westliche Länge und südliche Breite negativ! */
        /* converts UTM coords to LatLong;  3/22/95: by ChuckGantz chuck.gantz@globalstar.com, from USGS Bulletin 1532.
        Lat and Long are in degrees;  North latitudes and East Longitudes are positive.
        PARAMETER
            int eId 		der zu verwendende Elipsoid (siehe Ellipsoids.cs, Standard bei uns: 22 (WGS84))
            double Northing	UTM Nordwert
            double Easting	UTM Ostwert
            int Zone		UTM Zone
            double Lat	    Rückgabe: der Breitengrad (Nord ist positiv, Süd ist negativ)
            double Long	    Rückgabe: der Längengrad (Ost ist positiv, West ist negativ)
        */
        public void UTM_2_LL(
            int eId,
            double Northing,
            double Easting,
            int Zone,
            ref double Lat,
            ref double Long)
        {
            const double rad2deg = 180 / System.Math.PI;
            const double k0 = 0.9996;
            double a = ellipsoidBase.Ellipsoids[eId].EquatorialRadius;
            double ee = ellipsoidBase.Ellipsoids[eId].EccSquared;
            double EE = ee / (1 - ee);
            double e1 = (1 - System.Math.Sqrt(1 - ee)) / (1 + System.Math.Sqrt(1 - ee));
            double N1, T1, C1, R1, D, M, mu, phi1Rad;
            double x = Easting - 500000.0;        // remove 500,000 meter offset for longitude
            double y = Northing;
            double LongOrigin = Zone * 6 - 183;   // origin in middle of zone

            M = y / k0;
            mu = M / (a * (1 - ee / 4 - 3 * ee * ee / 64 - 5 * ee * ee * ee / 256));

            phi1Rad = mu + (3 * e1 / 2 - 27 * e1 * e1 * e1 / 32) * System.Math.Sin(2 * mu)
            + (21 * e1 * e1 / 16 - 55 * e1 * e1 * e1 * e1 / 32) * System.Math.Sin(4 * mu)
            + (151 * e1 * e1 * e1 / 96) * System.Math.Sin(6 * mu);
            N1 = a / System.Math.Sqrt(1 - ee * System.Math.Sin(phi1Rad) * System.Math.Sin(phi1Rad));
            T1 = System.Math.Tan(phi1Rad) * System.Math.Tan(phi1Rad);
            C1 = EE * System.Math.Cos(phi1Rad) * System.Math.Cos(phi1Rad);
            R1 = a * (1 - ee) / System.Math.Pow(1 - ee * System.Math.Sin(phi1Rad) * System.Math.Sin(phi1Rad), 1.5);
            D = x / (N1 * k0);

            Lat = phi1Rad - (N1 * System.Math.Tan(phi1Rad) / R1) * (D * D / 2 - (5 + 3 * T1 + 10 * C1 - 4 * C1 * C1 - 9 * EE) * D * D * D * D / 24
                                        + (61 + 90 * T1 + 298 * C1 + 45 * T1 * T1 - 252 * EE -
                                            3 * C1 * C1) * D * D * D * D * D * D / 720);
            Lat *= rad2deg;
            Long =
            (D - (1 + 2 * T1 + C1) * D * D * D / 6 +
            (5 - 2 * C1 + 28 * T1 - 3 * C1 * C1 + 8 * EE + 24 * T1 * T1) * D * D * D * D * D / 120) / System.Math.Cos(phi1Rad);
            Long = LongOrigin + Long * rad2deg;
        }
    }
}