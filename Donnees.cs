using System.Numerics;
using Raylib_cs;

namespace Breakout;

/// <summary>Les quatre états possibles du jeu.</summary>
enum EtatJeu
{
    Attente, // la balle est posée sur la raquette, en attente du lancement
    Jeu,     // la balle est en mouvement
    Perdu,   // plus aucune vie
    Gagne    // plus aucune brique
}

static partial class Program
{
    // Fenêtre
    const int LARGEUR = 800;
    const int HAUTEUR = 600;

    // Raquette
    const float LARGEUR_RAQUETTE = 100;
    const float HAUTEUR_RAQUETTE = 15;
    const float MARGE_BAS_RAQUETTE = 40;   // espace entre le bas de la raquette et le bas de la fenêtre
    const float VITESSE_RAQUETTE = 500;    // pixels par seconde

    // Balle
    const float RAYON_BALLE = 8;
    const float VITESSE_BALLE = 350;       // pixels par seconde

    // Briques
    const int LIGNES_BRIQUES = 1;
    const int COLONNES_BRIQUES = 10;
    const float ESPACE_BRIQUES = 6;        // espace entre deux briques, et entre une brique et le bord
    const float HAUTEUR_BRIQUE = 22;
    const float MARGE_HAUT_BRIQUES = 60;   // y du haut de la première ligne de briques
    const float LARGEUR_BRIQUE = LARGEUR / COLONNES_BRIQUES - ESPACE_BRIQUES * (COLONNES_BRIQUES + 1) / COLONNES_BRIQUES;

    // Règles
    const int POINTS_PAR_BRIQUE = 10;
    const int VIES_DEPART = 3;

    // État du jeu
    static EtatJeu etat = EtatJeu.Attente;
    static Vector2 positionRaquette;       // coin haut gauche de la raquette
    static Vector2 positionBalle;          // centre de la balle
    static Vector2 vitesseBalle;           // pixels par seconde, sur x et sur y
    static bool[,] briques = new bool[LIGNES_BRIQUES, COLONNES_BRIQUES]; // true = la brique existe
    static Rectangle[,] rectanglesBriques = new Rectangle[LIGNES_BRIQUES, COLONNES_BRIQUES]; // rectangles des briques
    static int score;
    static int vies = VIES_DEPART;

    static readonly Color[] couleursLignes =
    {
        Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.SkyBlue
    };
}
