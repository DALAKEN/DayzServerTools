namespace dayz;

struct Path
{
	static public string Root = "C:/AZOV-PVE-Chernarus";
	static public string Backup = $"{Root}/GitHub/Backup";

	static public string ProfilesBackup = $"{Backup}/profiles";
	static public string ProfilesServer = $"{Root}/profiles";
	static public string StorageServer = $"{Root}/mpmissions/dayzOffline.chernarusplus/storage_1";
}

static class Server
{
	static public void DeleteDirectory(string path)
	{
		DirectoryInfo dirInfo = new DirectoryInfo(path);
		if (dirInfo.Exists)
		{
			dirInfo.Delete(true);
			Console.WriteLine($"{dirInfo.Name} removed");
		}
		else Console.WriteLine($"{dirInfo.Name} not found");
	}
	static public void CopyDirectory(string fromDirectory, string toDirectory)
	{
		Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(fromDirectory, toDirectory);
	}
	static public void StartServer()
	{
	}
	static public void StopServer()
	{
	
	}
}

class Program
{
    static void Main()
    {
		//Server.DeleteDirectory(Path.StorageServer);
		//Server.DeleteDirectory(Path.ProfilesServer);

		//Server.CopyDirectory(Path.ProfilesBackup, Path.ProfilesServer);

		string mods = "@Better Weather 1.10;@Equipment System;@Flying Birds!;@No Sprinting Zombies;";
		string cParams = $"-config=serverDZ.cfg -port=2302 -cpuCount=4 -dologs -adminlog -netlog -freezecheck -profiles=profiles -BEpath={Path.Root}/battleye \"-mod={mods}\"";

		var proc = System.Diagnostics.Process.Start($"{Path.Root}/DayZServer_x64.exe", cParams);
	}
}