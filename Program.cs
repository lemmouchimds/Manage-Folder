using Manage_Folder;

//Manage app
Console.Write("Give me a folder : ");
string? path = Console.ReadLine();

//Directory.CreateDirectory(path + "\\hello");
var dir = new Dir();
dir.CreateUnexistDirectories(path);
dir.MoveFiles(path);


Console.WriteLine("Finished");
