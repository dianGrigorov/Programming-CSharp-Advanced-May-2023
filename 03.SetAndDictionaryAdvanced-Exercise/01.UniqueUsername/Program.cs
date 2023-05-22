
int n = int.Parse(Console.ReadLine());

HashSet<string> names = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();

    names.Add(name);
}
foreach (string name in names)
{
    Console.WriteLine(name);
}
//first.UnionWith(second);
//first.IntersectWith(second);
//first.ExceptWith(second);
//second.ExceptWith(first);
//second.SymmetricExceptWith(first);
//first.SymmetricExceptWith(second);