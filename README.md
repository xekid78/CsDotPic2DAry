# CsDotPic2DAry
二次元配列を使ったドット絵表示（.NET Core）

## 処理
二次元配列のデータを`for`文を使って出力する。。

## コード
```
using System;

namespace Dotary2d
{
    class Dotary2d
    {
        static void Main(string[] args)
        {
            int[][] letterA = 
            {
                new[] {0, 0, 1, 1, 0, 0},
                new[] {0, 1, 0, 0, 1, 0},
                new[] {1, 0, 0, 0, 0, 1},
                new[] {1, 1, 1, 1, 1, 1},
                new[] {1, 0, 0, 0, 0, 1},
                new[] {1, 0, 0, 0, 0, 1}
            };


            foreach (int[] line in letterA)
            {
                foreach (int dot in line)
                {
                    if (dot == 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
```

## 出力結果  
```
  ##
 #  #
#    #
######
#    #
#    #
```
  
## 開発環境
| 開発ツール |  |
|:-|:-|
| OS | Windows10 |
| 統合開発環境(IDE) | Visual Studio Community 2017 |
| 開発言語 | Visual C# |
