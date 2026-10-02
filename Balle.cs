using System.Numerics;
using Raylib_cs;
namespace Breakout;

static partial class Program
{
    /// <summary>Pose la balle au milieu du dessus de la raquette.</summary>
    static void CollerBalleARaquette()
    {
        positionBalle = new Vector2(positionRaquette.X + LARGEUR_RAQUETTE / 2, positionRaquette.Y - RAYON_BALLE);
        Raylib.DrawCircle((int)positionBalle.X, (int)positionBalle.Y, RAYON_BALLE, Color.White);
    }

    /// <summary>Donne à la balle sa vitesse de départ.</summary>
    static void LancerBalle()
    {
            vitesseBalle = new Vector2(VITESSE_BALLE, VITESSE_BALLE);
            positionBalle.X += vitesseBalle.X;
            positionBalle.Y += vitesseBalle.Y;
    }

    /// <summary>Avance la balle selon sa vitesse.</summary>
    static void DeplacerBalle(float dt)
    {
    }

    /// <summary>Fait rebondir la balle sur les murs gauche, droit et haut.</summary>
    static void RebondirSurMurs()
    {
    }

    /// <summary>Indique si la balle est entièrement sortie par le bas de la fenêtre.</summary>
    static bool BalleSortieEnBas()
    {
        return false;
    }
}
