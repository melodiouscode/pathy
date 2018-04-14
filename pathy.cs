using System;
using System.IO;
using System.Linq;

public static class Pathy {
	public static string Combine(string path1, params string[] paths) {
		return paths.Aggregate(path1, Combine);
	}

	private static string Combine(string path, string path2) {
		char spliter = Path.DirectorySeparatorChar;

		if (path == null) {
			throw new ArgumentException("Base path can not be null", nameof(path));
		}

		if (path2 == null) {
			throw new ArgumentException("Sub path can not be null", nameof(path2));
		}

		path = path.Trim().TrimEnd(spliter);
		path += spliter;
		path += path2.Trim().TrimStart(spliter);

		return path;
	}
}
