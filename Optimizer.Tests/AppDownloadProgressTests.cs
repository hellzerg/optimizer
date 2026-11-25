using Xunit;

namespace Optimizer.Tests {
    public sealed class AppDownloadProgressTests {
        [Theory]
        [InlineData(0L, -1L)]
        [InlineData(1L, -1L)]
        [InlineData(33554432L, -1L)]
        [InlineData(long.MaxValue, -1L)]
        [InlineData(0L, 0L)]
        [InlineData(1L, 0L)]
        [InlineData(1L, long.MinValue)]
        public void MissingOrInvalidLengthIsIndeterminate(long received, long total)
        {
            Assert.Null(AppDownloadProgress.Percentage(received, total));
        }

        [Theory]
        [InlineData(0L, 100L, 0)]
        [InlineData(-1L, 100L, 0)]
        [InlineData(long.MinValue, 100L, 0)]
        [InlineData(1L, 100L, 1)]
        [InlineData(1L, 3L, 33)]
        [InlineData(50L, 100L, 50)]
        [InlineData(99L, 100L, 99)]
        [InlineData(100L, 100L, 100)]
        [InlineData(101L, 100L, 100)]
        [InlineData(long.MaxValue, 1L, 100)]
        [InlineData(long.MaxValue, long.MaxValue, 100)]
        [InlineData(long.MaxValue - 1, long.MaxValue, 99)]
        [InlineData(10737418240L, 21474836480L, 50)]
        public void KnownLengthProducesABoundedPercentage(long received, long total, int expected)
        {
            int? percentage = AppDownloadProgress.Percentage(received, total);
            Assert.Equal(expected, percentage);
            Assert.InRange(percentage.Value, 0, 100);
        }
    }
}
