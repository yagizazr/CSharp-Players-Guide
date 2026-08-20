(SoupType type, MainIngredient mainIngredient, Seasoning seasoning) soup;

Console.Write("Welcome. Would you like to have a Soup, Stew or a Gumbo? ");
string typeInput = Console.ReadLine();
soup.type = typeInput.ToLower() switch
{
    "soup" => SoupType.Soup,
    "stew" => SoupType.Stew,
    "gumbo" => SoupType.Gumbo,
    _ => SoupType.Soup
};

Console.WriteLine("And for main ingredient would you like Mushrooms, Chicken, Carrots or Potatoes? ");
string mainIngredientInput = Console.ReadLine();
soup.mainIngredient = mainIngredientInput.ToLower() switch
{
    "mushrooms" => MainIngredient.Mushrooms,
    "chicken" => MainIngredient.Chicken,
    "carrots" => MainIngredient.Carrots,
    "potatoes" => MainIngredient.Potatoes,
    _ => MainIngredient.Mushrooms
};

Console.WriteLine("Finally for seasoning Spicy, Salty or Sweet? ");
string seasoningInput = Console.ReadLine();
soup.seasoning = seasoningInput.ToLower() switch
{
    "spicy" => Seasoning.Spicy,
    "salty" => Seasoning.Salty,
    "sweet" => Seasoning.Sweet,
    _ => Seasoning.Spicy
};

Console.WriteLine($"{soup.seasoning} {soup.mainIngredient} {soup.type}");

enum SoupType { Soup, Stew, Gumbo }
enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }