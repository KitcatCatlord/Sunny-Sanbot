using System;
using System.IO;
using System.Linq;

public static class Tools
{
    public static void OperationTest()
    {
        Maths("add", 3, 6);
    }
    public static double Maths(string operation, double a = 0, double b = 0) // Add operation list as an available operation
    {
        double result = operation.ToLower() switch
        {
            "add" => a + b,
            "sub" => a - b,
            "mul" => a * b,
            "div" => a / b,
            "mod" => a % b,
            "pow" => Math.Pow(a, b),
            "sqr" => Math.Sqrt(a),
            "cbr" => Math.Cbrt(a),
            "exp" => Math.Exp(a),
            "nlg" => Math.Log(a), // nlg for Natural LoG (base e)
            "log" => Math.Log(a, b),
            "xlg" => Math.Log10(a), // xlg as in x the roman numeral for 10
            "rnd" => Math.Round(a), // to nearest int by default
            "crd" => (double)Math.Round((decimal)a, (int)b), // crd for Custom RounD
            "flr" => Math.Floor(a),
            "cel" => Math.Ceiling(a),
            "trc" => Math.Truncate(a),
            "sin" => Math.Sin(a), // all in radians by default
            "cos" => Math.Cos(a),
            "tan" => Math.Tan(a),
            "asn" => Math.Asin(a),
            "acs" => Math.Acos(a),
            "atn" => Math.Atan(a),
            "att" => Math.Atan2(b, a), // att for ATan Two - takes y, x : reversed a and b
            "snh" => Math.Sinh(a),
            "csh" => Math.Cosh(a),
            "tnh" => Math.Tanh(a),
            _ => double.NaN
        };
        return result;
    }

    public static double constants(string request, bool requestUnit = false, bool requestSymbol = false) // implement unit and symbol request options ; add operation list as an option ; add notes for which numbers are approx
    {
        double result = request.ToLower() switch
        {
            "pi" => Math.PI,
            "e" => Math.E,
            "sol" => 299792458, // sol for Speed Of Light
            "vcpmb" => 1.25663706127 * Math.Pow(10, -6), // vcpmb for Vacuum PerMeaBility
            "vcpmt" => 8.854187818 * Math.Pow(10, -12), // vcpmt for Vacuum PerMiTtivity
            "coul" => 8.987 * Math.Pow(10, 9),
            "grav" => 6.67 * Math.Pow(10, -11),
            "plnk" => 6.62607015 * Math.Pow(10, -34),
            "rplnk" => 1.0545718 * Math.Pow(10, -34),
            "avog" => 6.02214076 * Math.Pow(10, 23),
            "boltz" => 1.380649 * Math.Pow(10, -23),
            "fsc" => 7.2973526 * Math.Pow(10, -3), // fsc for Fine Structure Constant
            "eul" => 0.57721,
            "gold" => 1.61803,
            _   => double.NaN
        };
        return result;
    }
}