using System;
using Xunit;
using IIG.BinaryFlag;

namespace XUnitTestProject2
{
    public class BinaryFlagTests
    {
        [Fact]
        // MBF - MultipleBinaryFlag
        public void MBF_0_1_2_9_True()
        {
            ulong value = 1;
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(value, true));
        }
        [Fact]
        public void MBF_0_1_2_9_False()
        {
            ulong value = 1;
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(value, false));
        }
        [Fact]
        public void MBF_0_1_3_2_9_True()
        {
            ulong value = 17179868705;
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(value, true));
        }
        [Fact]
        public void MBF_0_1_3_2_9_False()
        {
            ulong value = 17179868705;
            Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(value, false));
        }
        [Fact]
        public void MBF_0_1_3_4_5_9_True()
        {
            ulong value = 32;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
            Assert.NotNull(obj);
        }
        [Fact]
        public void MBF_0_1_3_4_5_9_False()
        {
            ulong value = 32;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
            Assert.NotNull(obj);
        }
        [Fact]
        public void MBF_0_1_3_4_6_8_9_True()
        {
            ulong value = 66;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
            Assert.NotNull(obj);
        }
        [Fact]
        public void MBF_0_1_3_4_6_8_9_False()
        {
            ulong value = 66;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
            Assert.NotNull(obj);
        }
        [Fact]
        public void MBF_0_1_3_4_6_7_9_True()
        {
            ulong value = 64;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
            Assert.NotNull(obj);
        }
        [Fact]
        public void MBF_0_1_3_4_6_7_9_False()
        {
            ulong value = 64;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
            Assert.NotNull(obj);
        }
        [Fact]
        public void SetFlag_0_1_2_3_12_True()
        {
            ulong value = 32;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
                obj.SetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void SetFlag_0_1_2_3_12_False()
        {
            ulong value = 32;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
                obj.SetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void SetFlag_0_1_5_6_8_12_True()
        {
            ulong value = 64;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
                obj.SetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void SetFlag_0_1_5_6_8_12_False()
        {
            ulong value = 64;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
                obj.SetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }
        }
        [Fact]
        public void SetFlag_0_1_5_9_11_12_True()
        {
            ulong value = 68;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
                obj.SetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void SetFlag_0_1_5_9_11_12_False()
        {
            ulong value = 68;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
                obj.SetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }
        }
        [Fact]
        public void ResetFlag_0_1_2_3_12_True()
        {
            ulong value = 32;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
                obj.ResetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void ResetFlag_0_1_2_3_12_False()
        {
            ulong value = 32;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
                obj.ResetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void ResetFlag_0_1_5_6_8_12_True()
        {
            ulong value = 64;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
                obj.ResetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void ResetFlag_0_1_5_6_8_12_False()
        {
            ulong value = 64;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
                obj.ResetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }
        }
        [Fact]
        public void ResetFlag_0_1_5_9_11_12_True()
        {
            ulong value = 68;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
                obj.ResetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void ResetFlag_0_1_5_9_11_12_False()
        {
            ulong value = 68;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
                obj.ResetFlag(20);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }
        }
        [Fact]
        public void GetFlag_0_1_2_4_11_True()
        {
            ulong value = 30;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
            bool? result = obj.GetFlag();
            Assert.NotNull(result);
        }
        [Fact]
        public void GetFlag_0_1_2_4_11_False()
        {
            ulong value = 30;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
            bool? result = obj.GetFlag();
            Assert.NotNull(result);
        }
        [Fact]
        public void GetFlag_0_1_5_6_8_11_True()
        {
            ulong value = 64;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
            bool? result = obj.GetFlag();
            Assert.NotNull(result);
        }
        [Fact]
        public void GetFlag_0_1_5_6_8_11_False()
        {
            ulong value = 64;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
            bool? result = obj.GetFlag();
            Assert.NotNull(result);
        }
        [Fact]
        public void GetFlag_0_1_5_9_10_11_True()
        {
            ulong value = 68;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
            bool? result = obj.GetFlag();
            Assert.NotNull(result);
        }
        [Fact]
        public void GetFlag_0_1_5_9_10_11_False()
        {
            ulong value = 68;
            MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
            bool? result = obj.GetFlag();
            Assert.NotNull(result);
        }
        [Fact]
        public void Dispose_0_1_4_5_True()
        {
            ulong value = 32;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
                obj.Dispose();
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void ResetFlag_0_1_4_5_False()
        {
            ulong value = 32;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
                obj.Dispose();
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }
        }
        [Fact]
        public void Dispose_0_1_2_4_5_True()
        {
            ulong value = 64;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
                obj.Dispose();
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void ResetFlag_0_1_2_4_5_False()
        {
            ulong value = 64;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
                obj.Dispose();
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }
        }
        [Fact]
        public void Dispose_0_1_2_3_4_5_True()
        {
            ulong value = 67;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, true);
                obj.Dispose();
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }

        }
        [Fact]
        public void ResetFlag_0_1_2_3_4_5_False()
        {
            ulong value = 67;
            try
            {
                MultipleBinaryFlag obj = new MultipleBinaryFlag(value, false);
                obj.Dispose();
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }
        }
    }
}
