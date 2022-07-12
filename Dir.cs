namespace Manage_Folder
{
    public class Dir
    {
        public Dir()
        {

        }

        public List<string> GetExtantions(string path)
        {
            var result = new List<string>();
            var files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                var extantion = Path.GetExtension(file);
                if(!result.Contains(extantion))
                {
                    result.Add(extantion);
                }
            }

            return result;
        }
    
        public void CreateUnexistDirectories(string path)
        {

            //look for all directories
            var directories = Directory.GetDirectories(path);

            //look for all existing directories
            var extantions = GetExtantions(path);

            //create new directories
            
            foreach(var Extantion in extantions)
            {
                if(!directories.Contains(Extantion))
                {
                    Directory.CreateDirectory(path + "\\" + Extantion);
                }
            }

        }

        public void MoveFiles(string path)
        {
            var files = Directory.GetFiles(path);
            var directories = Directory.GetDirectories(path);

            foreach(string file in files)
            {
                var temp = Path.Combine(path, Path.GetExtension(file), Path.GetFileName(file));
                Directory.Move(file, temp);
            }
            
        }
        
    }
}
