using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NBench.Util;
using NBench;
using ProjectManager.BusinessLib;
using ProjectManager.Entities;

namespace ProjectManager.Test
{
    [TestFixture]
    public class PerformanceTest
    {
        //private Counter _counter;

        //[PerfSetup]
        //public void Setup(BenchmarkContext context)
        //{
        //    _counter = context.GetCounter("TestCounter");
        //}

        //[PerfBenchmark(Description = "Test to ensure that a minimal throughput test can be rapidly executed.",
        //    NumberOfIterations = 3, RunMode = RunMode.Throughput,
        //    RunTimeMilliseconds = 1000, TestMode = TestMode.Test)]
        //[CounterThroughputAssertion("TestCounter", MustBe.GreaterThan, 10000000.0d)]
        //[MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.LessThanOrEqualTo, ByteConstants.ThirtyTwoKb)]
        //[GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        //public void Benchmark()
        //{
        //    _counter.Increment();
        //}
        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,
        TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 2000)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        public void Test_Perf_GetAllTask()
        {
            TaskBL obj = new TaskBL();
            var TestTasks = obj.GetAll();
        }

        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,
 TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 2000)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        public void Test_Perf_GetAllProject()
        {
            ProjectBL obj = new ProjectBL();
            var TestProjects = obj.GetAll();
        }

        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,
TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 2000)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        public void Test_Perf_GetAllUser()
        {
            UserBL obj = new UserBL();
            var TestUsers = obj.GetAll();
        }

        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,
        TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 2000)]
        [GcTotalAssertion(GcMetric.TotalCollections, GcGeneration.Gen2, MustBe.ExactlyEqualTo, 0.0d)]
        public void Test_D_AddTask()
        {
            Task item = new Task() { TaskId = 100,ParentId = 1,ProjectId = 1003,UserId = 2, TaskName = "PerfTestTask", ParentTask = "Task 10", Priority = 2, SDate = DateTime.Now, EDate = DateTime.Now, Status="Started", TaskEndFlag = true };
            TaskBL obj = new TaskBL();
            obj.AddTask(item);
        }

    }
}
