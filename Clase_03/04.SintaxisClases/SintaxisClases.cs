using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintaxisClases
{
    // Public -> Accesible desde cualquier proyecto
    public class ClasePublica
    {
        // ...
    }


    // Abstract -> Indica que la clase no podra instanciarse
    // ejemplo : no se podra hacer ClaseAbstracta clase = new ClaseAbstracta();
    abstract class ClaseAbstracta
    {
        // ...
    }

    // Private -> Indica que la clase no podra heredar
    class ClasePrivada
    {
        // ...
    }

    // Internal -> Accesible en todo el proyecto
    internal class ClaseInternal
    {
        // ...
    }
}
