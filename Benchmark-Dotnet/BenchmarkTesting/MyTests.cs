using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

[Config(typeof(Config))]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[CategoriesColumn]
public class MyTests
{

    #region 10

    [BenchmarkCategory("10 Iterations"), Benchmark(Baseline = true)]
    public void For10()
    {
        int[] array = Enumerable.Range(0, 10).ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    [BenchmarkCategory("10 Iterations"), Benchmark]
    public void ForEach10()
    {
        int[] array = Enumerable.Range(0, 10).ToArray();

        foreach (int a in array)
        {
            Console.WriteLine(a);
        }
    }

    #endregion

    #region 100

    [BenchmarkCategory("100 Iterations"), Benchmark(Baseline = true)]
    public void For100()
    {
        int[] array = Enumerable.Range(0, 100).ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    [BenchmarkCategory("100 Iterations"), Benchmark]
    public void ForEach100()
    {
        int[] array = Enumerable.Range(0, 100).ToArray();

        foreach (int a in array)
        {
            Console.WriteLine(a);
        }
    }

    #endregion

    #region 1000

    [BenchmarkCategory("1000 Iterations"), Benchmark(Baseline = true)]
    public void For1000()
    {
        int[] array = Enumerable.Range(0, 1000).ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    [BenchmarkCategory("1000 Iterations"), Benchmark]
    public void ForEach1000()
    {
        int[] array = Enumerable.Range(0, 1000).ToArray();

        foreach (int a in array)
        {
            Console.WriteLine(a);
        }
    }

    #endregion

    #region Config

    private class Config : ManualConfig
    {
        public Config()
        {
            SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Trend);
        }
    }

    #endregion

}