﻿namespace Humanizer.Tests.Localisation.roRO
{
    [UseCulture("ro-RO")]
    public class NumberToWordsTests
    {
        [Theory]
        [InlineData(-1, "minus unu")]
        [InlineData(0, "zero")]
        [InlineData(1, "unu")]
        [InlineData(2, "doi")]
        [InlineData(3, "trei")]
        [InlineData(4, "patru")]
        [InlineData(5, "cinci")]
        [InlineData(6, "șase")]
        [InlineData(7, "șapte")]
        [InlineData(8, "opt")]
        [InlineData(9, "nouă")]
        [InlineData(10, "zece")]
        [InlineData(11, "unsprezece")]
        [InlineData(12, "doisprezece")]
        [InlineData(13, "treisprezece")]
        [InlineData(14, "paisprezece")]
        [InlineData(15, "cincisprezece")]
        [InlineData(16, "șaisprezece")]
        [InlineData(17, "șaptesprezece")]
        [InlineData(18, "optsprezece")]
        [InlineData(19, "nouăsprezece")]
        [InlineData(20, "douăzeci")]
        [InlineData(21, "douăzeci și unu")]
        [InlineData(22, "douăzeci și doi")]
        [InlineData(30, "treizeci")]
        [InlineData(40, "patruzeci")]
        [InlineData(50, "cincizeci")]
        [InlineData(60, "șaizeci")]
        [InlineData(70, "șaptezeci")]
        [InlineData(80, "optzeci")]
        [InlineData(90, "nouăzeci")]
        [InlineData(100, "o sută")]
        [InlineData(101, "o sută unu")]
        [InlineData(102, "o sută doi")]
        [InlineData(111, "o sută unsprezece")]
        [InlineData(120, "o sută douăzeci")]
        [InlineData(121, "o sută douăzeci și unu")]
        [InlineData(122, "o sută douăzeci și doi")]
        [InlineData(200, "două sute")]
        [InlineData(1000, "o mie")]
        [InlineData(1001, "o mie unu")]
        [InlineData(1002, "o mie doi")]
        [InlineData(1100, "o mie o sută")]
        [InlineData(1200, "o mie două sute")]
        [InlineData(2000, "două mii")]
        [InlineData(10000, "zece mii")]
        [InlineData(12000, "douăsprezece mii")]
        [InlineData(20000, "douăzeci de mii")]
        [InlineData(21000, "douăzeci și una de mii")]
        [InlineData(22371, "douăzeci și două de mii trei sute șaptezeci și unu")]
        [InlineData(100000, "o sută de mii")]
        [InlineData(1000000, "un milion")]
        [InlineData(2000000, "două milioane")]
        [InlineData(1000000000, "un miliard")]
        [InlineData(2000000000, "două miliarde")]
        public void ToWords(int number, string expected) =>
            Assert.Equal(expected, number.ToWords());

        [Theory]
        [InlineData(-1, "minus unu")]
        [InlineData(0, "zero")]
        [InlineData(1, "unu")]
        [InlineData(2, "doi")]
        [InlineData(3, "trei")]
        [InlineData(4, "patru")]
        [InlineData(5, "cinci")]
        [InlineData(6, "șase")]
        [InlineData(7, "șapte")]
        [InlineData(8, "opt")]
        [InlineData(9, "nouă")]
        [InlineData(10, "zece")]
        [InlineData(11, "unsprezece")]
        [InlineData(12, "doisprezece")]
        [InlineData(13, "treisprezece")]
        [InlineData(14, "paisprezece")]
        [InlineData(15, "cincisprezece")]
        [InlineData(16, "șaisprezece")]
        [InlineData(17, "șaptesprezece")]
        [InlineData(18, "optsprezece")]
        [InlineData(19, "nouăsprezece")]
        [InlineData(20, "douăzeci")]
        [InlineData(21, "douăzeci și unu")]
        [InlineData(22, "douăzeci și doi")]
        [InlineData(30, "treizeci")]
        [InlineData(40, "patruzeci")]
        [InlineData(50, "cincizeci")]
        [InlineData(60, "șaizeci")]
        [InlineData(70, "șaptezeci")]
        [InlineData(80, "optzeci")]
        [InlineData(90, "nouăzeci")]
        [InlineData(100, "o sută")]
        [InlineData(101, "o sută unu")]
        [InlineData(102, "o sută doi")]
        [InlineData(111, "o sută unsprezece")]
        [InlineData(120, "o sută douăzeci")]
        [InlineData(121, "o sută douăzeci și unu")]
        [InlineData(122, "o sută douăzeci și doi")]
        [InlineData(200, "două sute")]
        [InlineData(1000, "o mie")]
        [InlineData(1001, "o mie unu")]
        [InlineData(1002, "o mie doi")]
        [InlineData(1100, "o mie o sută")]
        [InlineData(1200, "o mie două sute")]
        [InlineData(2000, "două mii")]
        [InlineData(10000, "zece mii")]
        [InlineData(12000, "douăsprezece mii")]
        [InlineData(20000, "douăzeci de mii")]
        [InlineData(21000, "douăzeci și una de mii")]
        [InlineData(22371, "douăzeci și două de mii trei sute șaptezeci și unu")]
        [InlineData(100000, "o sută de mii")]
        [InlineData(1000000, "un milion")]
        [InlineData(2000000, "două milioane")]
        [InlineData(1000000000, "un miliard")]
        [InlineData(2000000000, "două miliarde")]
        public void ToMasculineWords(int number, string expected) =>
            Assert.Equal(expected, number.ToWords(GrammaticalGender.Masculine));

        [Theory]
        [InlineData(-1, "minus una")]
        [InlineData(0, "zero")]
        [InlineData(1, "una")]
        [InlineData(2, "două")]
        [InlineData(3, "trei")]
        [InlineData(4, "patru")]
        [InlineData(5, "cinci")]
        [InlineData(6, "șase")]
        [InlineData(7, "șapte")]
        [InlineData(8, "opt")]
        [InlineData(9, "nouă")]
        [InlineData(10, "zece")]
        [InlineData(11, "unsprezece")]
        [InlineData(12, "douăsprezece")] // DOOM 2 (dicționarul ortografic, ortoepic și morfologic al limbii române)
        [InlineData(13, "treisprezece")]
        [InlineData(14, "paisprezece")]
        [InlineData(15, "cincisprezece")]
        [InlineData(16, "șaisprezece")]
        [InlineData(17, "șaptesprezece")]
        [InlineData(18, "optsprezece")]
        [InlineData(19, "nouăsprezece")]
        [InlineData(20, "douăzeci")]
        [InlineData(21, "douăzeci și una")]
        [InlineData(22, "douăzeci și două")]
        [InlineData(30, "treizeci")]
        [InlineData(40, "patruzeci")]
        [InlineData(50, "cincizeci")]
        [InlineData(60, "șaizeci")]
        [InlineData(70, "șaptezeci")]
        [InlineData(80, "optzeci")]
        [InlineData(90, "nouăzeci")]
        [InlineData(100, "o sută")]
        [InlineData(101, "o sută una")]
        [InlineData(102, "o sută două")]
        [InlineData(111, "o sută unsprezece")]
        [InlineData(120, "o sută douăzeci")]
        [InlineData(121, "o sută douăzeci și una")]
        [InlineData(122, "o sută douăzeci și două")]
        [InlineData(200, "două sute")]
        [InlineData(1000, "o mie")]
        [InlineData(1001, "o mie una")]
        [InlineData(1002, "o mie două")]
        [InlineData(1100, "o mie o sută")]
        [InlineData(1200, "o mie două sute")]
        [InlineData(2000, "două mii")]
        [InlineData(10000, "zece mii")]
        [InlineData(12000, "douăsprezece mii")]
        [InlineData(20000, "douăzeci de mii")]
        [InlineData(21000, "douăzeci și una de mii")]
        [InlineData(22371, "douăzeci și două de mii trei sute șaptezeci și una")]
        [InlineData(100000, "o sută de mii")]
        [InlineData(1000000, "un milion")]
        [InlineData(2000000, "două milioane")]
        [InlineData(1000000000, "un miliard")]
        [InlineData(2000000000, "două miliarde")]
        public void ToFeminineWords(int number, string expected) =>
            Assert.Equal(expected, number.ToWords(GrammaticalGender.Feminine));

        [Theory]
        [InlineData(-1, "minus unu")]
        [InlineData(0, "zero")]
        [InlineData(1, "unu")]
        [InlineData(2, "două")]
        [InlineData(3, "trei")]
        [InlineData(4, "patru")]
        [InlineData(5, "cinci")]
        public void ToNeuterWords(int number, string expected) =>
            Assert.Equal(expected, number.ToWords(GrammaticalGender.Neuter));

        // Test cases taken from Romanian Grammar, Mika Sarlin.

        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "primul")]
        [InlineData(2, "al doilea")]
        [InlineData(3, "al treilea")]
        [InlineData(4, "al patrulea")]
        [InlineData(5, "al cincilea")]
        [InlineData(6, "al șaselea")]
        [InlineData(7, "al șaptelea")]
        [InlineData(8, "al optulea")]
        [InlineData(9, "al nouălea")]
        [InlineData(10, "al zecelea")]
        [InlineData(11, "al unsprezecelea")]
        [InlineData(12, "al doisprezecelea")]
        [InlineData(13, "al treisprezecelea")]
        [InlineData(14, "al paisprezecelea")]
        [InlineData(15, "al cincisprezecelea")]
        [InlineData(16, "al șaisprezecelea")]
        [InlineData(17, "al șaptesprezecelea")]
        [InlineData(18, "al optsprezecelea")]
        [InlineData(19, "al nouăsprezecelea")]
        [InlineData(20, "al douăzecilea")]
        [InlineData(21, "al douăzeci și unulea")]
        [InlineData(22, "al douăzeci și doilea")]
        [InlineData(30, "al treizecilea")]
        [InlineData(40, "al patruzecilea")]
        [InlineData(50, "al cincizecilea")]
        [InlineData(60, "al șaizecilea")]
        [InlineData(70, "al șaptezecilea")]
        [InlineData(80, "al optzecilea")]
        [InlineData(90, "al nouăzecilea")]
        [InlineData(100, "al o sutălea")]
        [InlineData(101, "al o sută unulea")]
        [InlineData(102, "al o sută doilea")]
        [InlineData(199, "al o sută nouăzeci și nouălea")]
        [InlineData(200, "al două sutelea")]
        [InlineData(300, "al trei sutelea")]
        [InlineData(1000, "al o mielea")]
        [InlineData(1001, "al o mie unulea")]
        [InlineData(2000, "al două miilea")]
        [InlineData(10000, "al zece miilea")]
        [InlineData(20000, "al douăzeci miilea")]
        [InlineData(50000, "al cincizeci miilea")]
        [InlineData(1000000, "al un milionulea")]
        [InlineData(2000000, "al două milioanelea")]
        [InlineData(20000000, "al douăzeci milioanelea")]
        [InlineData(1000000000, "al un miliardulea")]
        [InlineData(2000000000, "al două miliardelea")]
        public void ToOrdinalWords(int number, string expected) =>
            Assert.Equal(expected, number.ToOrdinalWords());

        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "primul")]
        [InlineData(2, "al doilea")]
        [InlineData(3, "al treilea")]
        [InlineData(4, "al patrulea")]
        [InlineData(5, "al cincilea")]
        [InlineData(6, "al șaselea")]
        [InlineData(7, "al șaptelea")]
        [InlineData(8, "al optulea")]
        [InlineData(9, "al nouălea")]
        [InlineData(10, "al zecelea")]
        [InlineData(11, "al unsprezecelea")]
        [InlineData(12, "al doisprezecelea")]
        [InlineData(13, "al treisprezecelea")]
        [InlineData(14, "al paisprezecelea")]
        [InlineData(15, "al cincisprezecelea")]
        [InlineData(16, "al șaisprezecelea")]
        [InlineData(17, "al șaptesprezecelea")]
        [InlineData(18, "al optsprezecelea")]
        [InlineData(19, "al nouăsprezecelea")]
        [InlineData(20, "al douăzecilea")]
        [InlineData(21, "al douăzeci și unulea")]
        [InlineData(22, "al douăzeci și doilea")]
        [InlineData(30, "al treizecilea")]
        [InlineData(40, "al patruzecilea")]
        [InlineData(50, "al cincizecilea")]
        [InlineData(60, "al șaizecilea")]
        [InlineData(70, "al șaptezecilea")]
        [InlineData(80, "al optzecilea")]
        [InlineData(90, "al nouăzecilea")]
        [InlineData(100, "al o sutălea")]
        [InlineData(101, "al o sută unulea")]
        [InlineData(102, "al o sută doilea")]
        [InlineData(199, "al o sută nouăzeci și nouălea")]
        [InlineData(200, "al două sutelea")]
        [InlineData(300, "al trei sutelea")]
        [InlineData(1000, "al o mielea")]
        [InlineData(1001, "al o mie unulea")]
        [InlineData(2000, "al două miilea")]
        [InlineData(10000, "al zece miilea")]
        [InlineData(20000, "al douăzeci miilea")]
        [InlineData(50000, "al cincizeci miilea")]
        [InlineData(1000000, "al un milionulea")]
        [InlineData(2000000, "al două milioanelea")]
        [InlineData(20000000, "al douăzeci milioanelea")]
        [InlineData(1000000000, "al un miliardulea")]
        [InlineData(2000000000, "al două miliardelea")]
        public void ToMasculineOrdinalWords(int number, string expected) =>
            Assert.Equal(expected, number.ToOrdinalWords(GrammaticalGender.Masculine));

        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "prima")]
        [InlineData(2, "a doua")]
        [InlineData(3, "a treia")]
        [InlineData(4, "a patra")]
        [InlineData(5, "a cincea")]
        [InlineData(6, "a șasea")]
        [InlineData(7, "a șaptea")]
        [InlineData(8, "a opta")]
        [InlineData(9, "a noua")]
        [InlineData(10, "a zecea")]
        [InlineData(11, "a unsprezecea")]
        [InlineData(12, "a douăsprezecea")]
        [InlineData(13, "a treisprezecea")]
        [InlineData(14, "a paisprezecea")]
        [InlineData(15, "a cincisprezecea")]
        [InlineData(16, "a șaisprezecea")]
        [InlineData(17, "a șaptesprezecea")]
        [InlineData(18, "a optsprezecea")]
        [InlineData(19, "a nouăsprezecea")]
        [InlineData(20, "a douăzecea")]
        [InlineData(21, "a douăzeci și una")]
        [InlineData(22, "a douăzeci și doua")]
        [InlineData(30, "a treizecea")]
        [InlineData(40, "a patruzecea")]
        [InlineData(50, "a cincizecea")]
        [InlineData(60, "a șaizecea")]
        [InlineData(70, "a șaptezecea")]
        [InlineData(80, "a optzecea")]
        [InlineData(90, "a nouăzecea")]
        [InlineData(100, "a o suta")]
        [InlineData(101, "a o sută una")]
        [InlineData(102, "a o sută doua")]
        [InlineData(199, "a o sută nouăzeci și noua")]
        [InlineData(200, "a două suta")]
        [InlineData(300, "a trei suta")]
        [InlineData(1000, "a o mia")]
        [InlineData(1001, "a o mie una")]
        [InlineData(2000, "a două mia")]
        [InlineData(10000, "a zece mia")]
        [InlineData(20000, "a douăzeci mia")]
        [InlineData(50000, "a cincizeci mia")]
        [InlineData(1000000, "a milioana")]
        [InlineData(2000000, "a două milioana")]
        [InlineData(20000000, "a douăzecea milioana")]
        [InlineData(1000000000, "a miliarda")]
        [InlineData(2000000000, "a două miliarda")]
        public void ToFeminineOrdinalWords(int number, string expected) =>
            Assert.Equal(expected, number.ToOrdinalWords(GrammaticalGender.Feminine));

        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "primul")]
        [InlineData(2, "al doilea")]
        [InlineData(3, "al treilea")]
        [InlineData(4, "al patrulea")]
        [InlineData(5, "al cincilea")]
        public void ToNeuterOrdinalWords(int number, string expected) =>
            Assert.Equal(expected, number.ToOrdinalWords(GrammaticalGender.Neuter));
    }
}