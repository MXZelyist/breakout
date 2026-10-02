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
    }

    /// <summary>Avance la balle selon sa vitesse.</summary>
    static void DeplacerBalle(float dt)
    {
        positionBalle.X += vitesseBalle.X * dt;
        positionBalle.Y += -vitesseBalle.Y * dt;
    }

    /// <summary>Fait rebondir la balle sur les murs gauche, droit et haut.</summary>
    static void RebondirSurMurs()
    {
        if(positionBalle.X - RAYON_BALLE < 0 || positionBalle.X + RAYON_BALLE > LARGEUR)
        {
            vitesseBalle.X *= -vitesseBalle.X / vitesseBalle.X;
        }
        if(positionBalle.Y - RAYON_BALLE < 0)
        {
            vitesseBalle.Y *= -vitesseBalle.Y / vitesseBalle.Y;
        }
    }

    /// <summary>Indique si la balle est entièrement sortie par le bas de la fenêtre.</summary>
    static bool BalleSortieEnBas()
    {
        return false;
    }
}
