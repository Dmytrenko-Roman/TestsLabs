using System;
using Xunit;
using IIG.PasswordHashingUtils;


namespace PasswordHashingLibTest
{
    public class Tests
    {
        [Fact]
        public void GetHash_SameParams_IsEqual()
        {
            string password = "pavlov";
            string salt = "qwerty";
            uint adlerMod32 = 3;
            string expected = PasswordHasher.GetHash(password, salt, adlerMod32);
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetHash_DiffParamFirst_IsNotEqual()
        {
            string password1 = "pavlov";
            string password2 = "silva";
            string salt = "qwerty";
            uint adlerMod32 = 3;
            string expected = PasswordHasher.GetHash(password1, salt, adlerMod32);
            string actual = PasswordHasher.GetHash(password2, salt, adlerMod32);
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void GetHash_DiffParamSecond_IsNotEqual()
        {
            string password = "pavlov";
            string salt1 = "qwerty";
            string salt2 = "sking";
            uint adlerMod32 = 3;
            string expected = PasswordHasher.GetHash(password, salt1, adlerMod32);
            string actual = PasswordHasher.GetHash(password, salt2, adlerMod32);
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void GetHash_DiffParamThird_IsNotEqual()
        {
            string password = "pavlov";
            string salt = "qwerty";
            uint adlerMod32_1 = 3;
            uint adlerMod32_2 = 4;
            string expected = PasswordHasher.GetHash(password, salt, adlerMod32_1);
            string actual = PasswordHasher.GetHash(password, salt, adlerMod32_2);
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void GetHash_DiffParams_IsNotEqual()
        {
            string password1 = "pavlov";
            string password2 = "porev";
            string salt1 = "qwerty";
            string salt2 = "asdasdasd";
            uint adlerMod32_1 = 3;
            uint adlerMod32_2 = 4;
            string expected = PasswordHasher.GetHash(password1, salt1, adlerMod32_1);
            string actual = PasswordHasher.GetHash(password2, salt2, adlerMod32_2);
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void GetHash_NotNullParams_ReturnsNotNull()
        {
            string password = "pavlov";
            string salt = "qwerty";
            uint adlerMod32 = 3;
            string str = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(str);
        }
        [Fact]
        public void GetHash_FirstNull_ReturnsNull()
        {
            string password = null;
            string salt = "qwerty";
            uint adlerMod32 = 3;
            string str = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.Null(str);
        }
        [Fact]
        public void GetHash_SecondNull_ReturnsNotNull()
        {
            string password = "pavlov";
            string salt = null;
            uint adlerMod32 = 3;
            string str = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(str);
        }
        [Fact]
        public void GetHash_NumberInPasswd_ReturnsNotNull()
        {
            string password = "111";
            string salt = "qwerty";
            uint adlerMod32 = 3;
            string str = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(str);
        }
        [Fact]
        public void GetHash_NumberInSalt_ReturnsNotNull()
        {
            string password = "pavlov";
            string salt = "56";
            uint adlerMod32 = 3;
            string str = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(str);
        }
        [Fact]
        public void GetHash_BigNumber_ReturnsNotNull()
        {
            string password = "pavlov";
            string salt = "qwerty";
            uint adlerMod32 = 1000000000;
            string str = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(str);
        }
        [Fact]
        public void GetHash_CyrillicPasswd_ReturnsNotNull()
        {
            string password = "павлов";
            string salt = "qwerty";
            uint adlerMod32 = 3;
            string str = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(str);
        }
        [Fact]
        public void GetHash_CyrillicSalt_ReturnsNotNull()
        {
            string password = "pavlov";
            string salt = "кверти";
            uint adlerMod32 = 3;
            string str = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(str);
        }
        [Fact]
        public void GetHash_CyrillicPasswdSalt_ReturnsNotNull()
        {
            string password = "павлов";
            string salt = "кверти";
            uint adlerMod32 = 3;
            string str = PasswordHasher.GetHash(password, salt, adlerMod32);
            Assert.NotNull(str);
        }
        [Fact]
        public void Init_TryToInit_CatchErr()
        {
            string salt = "qwerty";
            uint adlerMod32 = 3;
            try
            {
                PasswordHasher.Init(salt, adlerMod32);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
    }
}
