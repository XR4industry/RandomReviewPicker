using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RandomReviewPicker;
internal class ReviewPicker
{
	public List<ScriptFileInfo> ScriptInfos { get; set; } = new();

	public List<string> GetScriptFilePaths(string folder) 
		=> Directory.GetFiles(folder, "*.cs", SearchOption.AllDirectories).ToList();

	public List<string> ExcludeFoldersFromFilePathList(List<string> paths, List<string> Forbidden)
	{
		var filteredPathList = new List<string>();

		foreach (var path in paths)
		{
			if(!Forbidden.Any(x => path.Contains(x)))
			{
				filteredPathList.Add(path);
			}
		}

		return filteredPathList;
	}

	public List<ScriptFileInfo> GetScriptInfo(List<string> Files)
	{
		var list = new List<ScriptFileInfo>();

		Parallel.For(0, Files.Count,
				   index => {
					   FileInfo info = new(Files[index]);
					   ScriptFileInfo scriptInfo = new() 
					   {
						   Name = info.Name,
						   Path = Files[index],
						   Lines = File.ReadAllLines(Files[index]).Count(),
						   Characters = File.ReadAllText(Files[index]).Count(),
						   ScriptReview = Review.GetReview(Files[index])
					   };

					   list.Add(scriptInfo);
				   });

		return list;
	}

	public ScriptFileInfo Pick(List<ScriptFileInfo> fileInfos)
	{
		Random random = new();
		int randomNumber = random.Next(0, fileInfos.Count);

		return fileInfos[randomNumber];
	}

}
