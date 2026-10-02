using Raylib_cs;

namespace Breakout;

static partial class Program
{
    /// <summary>Le rectangle occupé à l'écran par la brique (ligne, colonne).</summary>
    static Rectangle RectangleBrique(int ligne, int colonne)
    {
        return new Rectangle(ESPACE_BRIQUES + colonne * (LARGEUR_BRIQUE + ESPACE_BRIQUES),
                             MARGE_HAUT_BRIQUES + ligne * (HAUTEUR_BRIQUE + ESPACE_BRIQUES),
                             LARGEUR_BRIQUE, HAUTEUR_BRIQUE);
    }

    /// <summary>Casse la brique touchée par la balle, fait rebondir la balle et ajoute les points.</summary>
    static void CasserBriques()
    {
        for (int i = 0; i < LIGNES_BRIQUES; i++)
        {
            for (int j = 0; j < COLONNES_BRIQUES; j++)
            {
                if (Raylib.CheckCollisionCircleRec(positionBalle, RAYON_BALLE, rectanglesBriques[i,j]))
                {
                    briques[i,j] = false;
                    vitesseBalle.Y = -vitesseBalle.Y;
                }
            }
        }
    }

    /// <summary>Le nombre de briques encore présentes.</summary>
    static int CompterBriques()
    {
        return 0;
    }

    /// <summary>Dessine les briques encore présentes, une couleur par ligne.</summary>
    static void DessinerBriques()
    {
        for(int i = 0; i < LIGNES_BRIQUES; i++)
        {
            for (int j = 0; j < COLONNES_BRIQUES; j++)
            {
                if (briques[i,j]){
                    rectanglesBriques[i, j] = RectangleBrique(i, j);
                    Raylib.DrawRectangleRec(rectanglesBriques[i, j], couleursLignes[i]);
                }
            }
        }
    }
}
