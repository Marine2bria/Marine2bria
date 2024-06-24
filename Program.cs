
Console.Beep(); //ca fait bip
Console.Clear(); //ca clear la console
Console.Write("Les variables : \n\n"); // ecrit sur la console et saute la ligne grace au \n

// les variable et print

int age = 18; // on mais le type de la variable avant de la cree et les type sont un peu pareil en python juste faut faire attention a pas depasser des valeurs (voir tableau)
Console.WriteLine("age : " + age); // ecrit sur la console et saute la ligne apres automatiquement
string result; // pas oublier le ; !!!!
int rd = default; //attribut une valeur par defaut
Console.WriteLine("default : " + rd); //ici on voit que c'est 0 du coup
string name = "marine";
Console.WriteLine("nom : " + name);

Console.Write("\n Les conditions : \n\n");

// les conditions

// a noter que le langue lie tout en ascii donc tu peux comparer des lettre et des chiffre c'est ok

if(age<18) // pas de ; pour le truc comme ca
    result = "mineur";
else if(age == 18) //equivalent du elif en python donc sinon si
    result = "tout juste majeur";
else
    result = "majeur";
Console.WriteLine(result); 
result = (age >= 18) ? "majeur" : "mineur"; // ? c'est un peu un if en plus simple et du coup si vrai il donne a result la premier valeur sinon celle apres les :
Console.WriteLine(result);

bool pass = true; //true et false sans maj
if (result == "majeur" || pass == true) // || c'est OU
    Console.WriteLine("peux passer");

if (age > 18 && age < 50) // && c'est ET
    Console.WriteLine("\t jsp"); // \t c'est un alinea

switch(age) //en gros on fait une separation des cas pour age
    { // {} a mettre quand + de 1 instruction apres tout le truc qui necessite un tab (genre if else le boucle et les merde comme ca)
        case <18 : //dans le cas ou age<18...
            result = "mineur";
            break; //ca sert a rien de faire les autre test donc on sort
        case >18 :
            result = "majeur";
            break;
        default ://si aucun des autre truc est respecté
            Console.WriteLine("tout juste majeur");
            break; //pas oublier celui la surtout sinon boucle le programme crash
    }

Console.WriteLine($"{name} à {age} ans."); //meme choses que avec les + mais mieux. en python c'est f et pas $


Console.Write("\n Les boucles : \n\n"); // \n c'est un saut de ligne

// les boucles


for(int i = 0; i<10;i++) //initialisation; condition; imcrementation (ici i++ c'est i = i + 1. il existe aussi -- qui fait -1) equivalent de for i in range avec le premier nb le dernier et le pas
    Console.Write(i); 

Console.WriteLine(""); // saut de ligne aussi

foreach(char elt in name) //pour chaque element de name
    Console.Write(elt);

Console.Write("\n");

int y = 0;
while( y  < 4)
    { 
        Console.Write(y);
        y += 1; //increment de 1 exactement comme y = y+1. Il existe aussi -=, *=, /= qui font pareil avec des opperation differente
        if(y==2) // sur l'execution c'est quand y = 1 mais c'est normal parce qu'on print puis on incremente puis on fait ca mais faut pas incremente apres le continue sinon boucle infinie
        {
            Console.WriteLine("\t Non");
            continue; //vas recommencer la boucle sans effectuer la suite des instruction donc pas de print "ok"
        }
        Console.WriteLine("\t OK");     
    }
        
Console.Write("\n Lecture du clavier : \n\n"); 

// lecture du clavier

Console.WriteLine("la premiere lettre sera traduite en ascii sur la ligne suivant et le reste du message réecrit en dessus.\nOublie pas de cliquer sur une touche à la fin !");

int c = Console.Read(); //prend en compte que la premiere lettre que tu mets
Console.WriteLine(c); //te l'ecrit en code ascii (pratique si flemme de regarder le tableau sur google)

string s = Console.ReadLine(); //prend en compte tout ce que tu ecris jusqu'à que tu clique sur entrer
Console.WriteLine(s); //te reecrit juste tout en str

ConsoleKeyInfo cki = Console.ReadKey();
Console.WriteLine(cki); //pas trop compris a voir mais en gros quand tu touches une touche ca fait un truc ??

Console.Write("\n Les methodes : \n\n"); 

//les methodes

static void Say(string message) 
/*static c'est obligatoir mais je comprend pas trop ce que c'est, y'a surment d'autre truc possible (genre override). 
void c'est ce que ca retourne, donc rien ici, mais on peux mettre autre chose genre int. 
La maj au debut du nom de la fonction c'est une convention.
dans les parametres faut preciser le type de chaque parametre*/
{
    Console.WriteLine(message);
}

Say("Coucou !");

static int Sum(int x, int y) //autre ex avec un return
{
    return x + y;
}

int somme = Sum(4,6);
Console.WriteLine("resultat de somme avec 4 et 6 en parametres : "  + somme);

static void Fois(ref int x, int y = 2) 
/*ref ca fait directement reference a la variable placer en parametre et quand on modifie les parametre ca modif la variable
le y ici est pas obligatoir et si il est pas mis on va considere que c'est 2*/
{
    x = x*y;
}

int nb = 5;
Console.WriteLine("nombre : " + nb);
Fois(ref nb); //pas oublier de remettre le ref dans l'appel de la fonction. Du coup ici *2
Console.WriteLine("nombre apres la methode fois (ici fois 2) : " + nb);
Fois(ref nb,3); //ici *3
Console.WriteLine("nombre apres une autre application de la methode fois (ici fois 3) : " + nb);

Console.Write("\n Les structures : \n\n");

//les structures

//la structure donc etre cree apres le code de base sinon on peux pas l'utiliser ??? du coup va voir a la fin du program
//Les structure ne sont pas faite pour que les donnees soit modifie

Disk d = new Disk("ntm", 500);
Console.WriteLine(d);

Console.Write("\n Les class : \n\n");

//Les class
struct Disk
{
    public string Band; // le public c'est pour qu'on puisse acceder au info en dehors de la structure
    public int Capacity; //en go

    public Disk(string band, int capacity) //constructeur de la structure pas obligatoire
    {
        Band = band;
        Capacity = capacity;
    }

    public override string ToString() => $"Disque du groupe {Band}, d'une capacite de {Capacity}Go.";
    /* creation de fonction rapide (que quand y'a qu'une ligne de commande)
    override -> modification d'une fonctione deja existante*/
}



