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

    public static double constants(string request, bool requestUnit = false, bool requestSymbol = false) // implements unit and symbol request options ; adds list option ; notes which are approx
    {
        if (string.IsNullOrWhiteSpace(request)) return double.NaN;

        string key = request.ToLower();

        // list supported constants with symbols and units
        if (key == "list" || key == "ops" || key == "help")
        {
            Console.WriteLine("Available constants (code : symbol [unit]):");
            Console.WriteLine("pi   : π [unitless]");
            Console.WriteLine("e    : e [unitless]");
            Console.WriteLine("sol  : c [m/s]"); // sol for Speed Of Light
            Console.WriteLine("vcpmb: μ0 [H/m]"); // vcpmb for Vacuum PerMeaBility
            Console.WriteLine("vcpmt: ε0 [F/m]"); // vcpmt for Vacuum PerMiTtivity
            Console.WriteLine("coul : k_e [N·m^2/C^2]");
            Console.WriteLine("grav : G [N·m^2/kg^2]");
            Console.WriteLine("plnk : h [J·s]");
            Console.WriteLine("rplnk: ħ [J·s]");
            Console.WriteLine("avog : N_A [1/mol]");
            Console.WriteLine("boltz: k_B [J/K]");
            Console.WriteLine("fsc  : α [unitless]"); // fsc for Fine Structure Constant
            Console.WriteLine("eul  : γ [unitless]");
            Console.WriteLine("gold : φ [unitless]");
            return double.NaN; // list request has no numeric result
        }

        double result = key switch
        {
            "pi" => Math.PI,
            "e" => Math.E,
            "sol" => 299792458, // sol for Speed Of Light (exact)
            "vcpmb" => 1.25663706127 * Math.Pow(10, -6), // vcpmb for Vacuum PerMeaBility (approx)
            "vcpmt" => 8.854187818 * Math.Pow(10, -12), // vcpmt for Vacuum PerMiTtivity (approx)
            "coul" => 8.987 * Math.Pow(10, 9), // Coulomb constant (approx)
            "grav" => 6.67 * Math.Pow(10, -11), // Gravitational constant (approx)
            "plnk" => 6.62607015 * Math.Pow(10, -34), // Planck constant (defined exact)
            "rplnk" => 1.0545718 * Math.Pow(10, -34), // Reduced Planck's constant (approx decimal)
            "avog" => 6.02214076 * Math.Pow(10, 23), // Avogadro (defined exact)
            "boltz" => 1.380649 * Math.Pow(10, -23), // Boltzmann (defined exact)
            "fsc" => 7.2973526 * Math.Pow(10, -3), // fsc for Fine Structure Constant (approx)
            "eul" => 0.57721, // Euler–Mascheroni (approx)
            "gold" => 1.61803, // Golden ratio (approx)
            _   => double.NaN
        };

        // optionally print unit and/or symbol
        if (requestUnit || requestSymbol)
        {
            string unit = key switch
            {
                "sol" => "m/s",
                "vcpmb" => "H/m",
                "vcpmt" => "F/m",
                "coul" => "N·m^2/C^2",
                "grav" => "N·m^2/kg^2",
                "plnk" => "J·s",
                "rplnk" => "J·s",
                "avog" => "1/mol",
                "boltz" => "J/K",
                _ => "unitless"
            };

            string symbol = key switch
            {
                "pi" => "π",
                "e" => "e",
                "sol" => "c",
                "vcpmb" => "μ0",
                "vcpmt" => "ε0",
                "coul" => "k_e",
                "grav" => "G",
                "plnk" => "h",
                "rplnk" => "ħ",
                "avog" => "N_A",
                "boltz" => "k_B",
                "fsc" => "α",
                "eul" => "γ",
                "gold" => "φ",
                _ => ""
            };

            // only print for known keys
            if (!double.IsNaN(result))
            {
                if (requestSymbol && requestUnit)
                {
                    Console.WriteLine($"{symbol} [{unit}]");
                }
                else if (requestSymbol)
                {
                    Console.WriteLine(symbol);
                }
                else if (requestUnit)
                {
                    Console.WriteLine(unit);
                }
            }
        }
        return result;
    }
}
