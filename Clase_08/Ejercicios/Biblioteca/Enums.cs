using System.ComponentModel;

namespace Biblioteca
{
    /// <summary>
    /// Enumerado que representa el tipo de género de música.
    /// </summary>
    public enum ETipo
    {
        Cumbia,
        Rock,
        Pop,
        Techno,
        Salsa,
        HipHop,
        Reggaeton
    }

    public enum EGenero
    {
        [Description("Masculino")]
        Masculino,
        [Description("Femenino")]
        Femenino,
        [Description("No binario")]
        NoBinario
    }
}
