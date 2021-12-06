using System.Collections.Generic;

namespace StoneageTools.Coordinatesbase
{
    public class EllipsoidStructure
    {
        public int Id                   { get; }
        public string Name              { get; }
        public double EquatorialRadius  { get; }
        public double EccSquared        { get; }

        public EllipsoidStructure(int id, string name, double radius, double fr)
        {
            Id = id;
            Name = name;
            EquatorialRadius = radius;
            EccSquared = (2 / fr) - (1 / (fr * fr));
        }
    }

    public class EllipsoidBase
    {
        public List<EllipsoidStructure> Ellipsoids { get; set; } = new();

        public EllipsoidBase()
        {
            Ellipsoids.Add(new EllipsoidStructure( 0, "Airy1830", 6377563.396, 299.3249646));
            Ellipsoids.Add(new EllipsoidStructure( 1, "AiryModified", 6377340.189, 299.3249646));
            Ellipsoids.Add(new EllipsoidStructure( 2, "AustralianNational", 6378160, 298.25));
            Ellipsoids.Add(new EllipsoidStructure( 3, "Bessel1841Namibia", 6377483.865, 299.1528128));
            Ellipsoids.Add(new EllipsoidStructure( 4, "Bessel1841", 6377397.155, 299.1528128));
            Ellipsoids.Add(new EllipsoidStructure( 5, "Clarke1866", 6378206.4, 294.9786982));
            Ellipsoids.Add(new EllipsoidStructure( 6, "Clarke1880", 6378249.145, 293.465));
            Ellipsoids.Add(new EllipsoidStructure( 7, "EverestIndia1830", 6377276.345, 300.8017));
            Ellipsoids.Add(new EllipsoidStructure( 8, "EverestSabahSarawak", 6377298.556, 300.8017));
            Ellipsoids.Add(new EllipsoidStructure( 9, "EverestIndia1956", 6377301.243, 300.8017));
            Ellipsoids.Add(new EllipsoidStructure(10, "EverestMalaysia1969", 6377295.664, 300.8017));
            Ellipsoids.Add(new EllipsoidStructure(11, "EverestMalay_Sing", 6377304.063, 300.8017));
            Ellipsoids.Add(new EllipsoidStructure(12, "EverestPakistan", 6377309.613, 300.8017));
            Ellipsoids.Add(new EllipsoidStructure(13, "Fischer1960Modified", 6378155, 298.3));
            Ellipsoids.Add(new EllipsoidStructure(14, "Helmert1906", 6378200, 298.3));
            Ellipsoids.Add(new EllipsoidStructure(15, "Hough1960", 6378270, 297));
            Ellipsoids.Add(new EllipsoidStructure(16, "Indonesian1974", 6378160, 298.247));
            Ellipsoids.Add(new EllipsoidStructure(17, "International1924", 6378388, 297));
            Ellipsoids.Add(new EllipsoidStructure(18, "Krassovsky1940", 6378245, 298.3));
            Ellipsoids.Add(new EllipsoidStructure(19, "GRS80", 6378137, 298.257222101));
            Ellipsoids.Add(new EllipsoidStructure(20, "SouthAmerican1969", 6378160, 298.25));
            Ellipsoids.Add(new EllipsoidStructure(21, "WGS72", 6378135, 298.26));
            Ellipsoids.Add(new EllipsoidStructure(22, "WGS84", 6378137, 298.257223563));
        }

        public static int EllipsoidCheckValid(int CheckEllipsoidNumber)     => (CheckEllipsoidNumber is < 1 or > 22) ? 22 : CheckEllipsoidNumber;
    };
}