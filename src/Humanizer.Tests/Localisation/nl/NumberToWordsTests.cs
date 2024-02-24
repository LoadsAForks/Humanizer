﻿namespace Humanizer.Tests.Localisation.nl
{
    [UseCulture("nl-NL")]
    public class NumberToWordsTests
    {
        [Theory]
        [InlineData(0, "nul")]
        [InlineData(1, "een")]
        [InlineData(-10, "min tien")]
        [InlineData(10, "tien")]
        [InlineData(11, "elf")]
        [InlineData(122, "honderdtweeëntwintig")]
        [InlineData(3501, "drieduizend vijfhonderdeen")]
        [InlineData(100, "honderd")]
        [InlineData(1000, "duizend")]
        [InlineData(100000, "honderdduizend")]
        [InlineData(1000000, "een miljoen")]
        [InlineData(10000000, "tien miljoen")]
        [InlineData(100000000, "honderd miljoen")]
        [InlineData(1000000000, "een miljard")]
        [InlineData(111, "honderdelf")]
        [InlineData(1111, "duizend honderdelf")]
        [InlineData(111111, "honderdelfduizend honderdelf")]
        [InlineData(1111111, "een miljoen honderdelfduizend honderdelf")]
        [InlineData(11111111, "elf miljoen honderdelfduizend honderdelf")]
        [InlineData(111111111, "honderdelf miljoen honderdelfduizend honderdelf")]
        [InlineData(1111111111, "een miljard honderdelf miljoen honderdelfduizend honderdelf")]
        [InlineData(123, "honderddrieëntwintig")]
        [InlineData(124, "honderdvierentwintig")]
        [InlineData(1234, "duizend tweehonderdvierendertig")]
        [InlineData(12345, "twaalfduizend driehonderdvijfenveertig")]
        [InlineData(123456, "honderddrieëntwintigduizend vierhonderdzesenvijftig")]
        [InlineData(1234567, "een miljoen tweehonderdvierendertigduizend vijfhonderdzevenenzestig")]
        [InlineData(12345678, "twaalf miljoen driehonderdvijfenveertigduizend zeshonderdachtenzeventig")]
        [InlineData(123456789, "honderddrieëntwintig miljoen vierhonderdzesenvijftigduizend zevenhonderdnegenentachtig")]
        [InlineData(1234567890, "een miljard tweehonderdvierendertig miljoen vijfhonderdzevenenzestigduizend achthonderdnegentig")]
        [InlineData(1234567899, "een miljard tweehonderdvierendertig miljoen vijfhonderdzevenenzestigduizend achthonderdnegenennegentig")]
        [InlineData(108, "honderdacht")]
        [InlineData(678, "zeshonderdachtenzeventig")]
        [InlineData(2013, "tweeduizend dertien")]
        [InlineData(2577, "tweeduizend vijfhonderdzevenenzeventig")]
        [InlineData(17053980, "zeventien miljoen drieënvijftigduizend negenhonderdtachtig")]
        [InlineData(415618, "vierhonderdvijftienduizend zeshonderdachttien")]
        [InlineData(16415618, "zestien miljoen vierhonderdvijftienduizend zeshonderdachttien")]
        [InlineData(322, "driehonderdtweeëntwintig")]
        public void IntToWords(int number, string expected) =>
            Assert.Equal(expected, number.ToWords());

        [Theory]
        [InlineData(100_000_000_000L, "honderd miljard")]
        [InlineData(1_000_000_000_000L, "een biljoen")]
        [InlineData(100_000_000_000_000L, "honderd biljoen")]
        [InlineData(1_000_000_000_000_000L, "een biljard")]
        [InlineData(100_000_000_000_000_000L, "honderd biljard")]
        [InlineData(1_000_000_000_000_000_000L, "een triljoen")]
        [InlineData(9_223_372_036_854_775_807L, "negen triljoen tweehonderddrieëntwintig biljard driehonderdtweeënzeventig biljoen zesendertig miljard achthonderdvierenvijftig miljoen zevenhonderdvijfenzeventigduizend achthonderdzeven")]
        public void LongToWords(long number, string expected) =>
            Assert.Equal(expected, number.ToWords());

        [Theory]
        [InlineData(0, "nulde")]
        [InlineData(1, "eerste")]
        [InlineData(2, "tweede")]
        [InlineData(3, "derde")]
        [InlineData(4, "vierde")]
        [InlineData(5, "vijfde")]
        [InlineData(6, "zesde")]
        [InlineData(7, "zevende")]
        [InlineData(8, "achtste")]
        [InlineData(9, "negende")]
        [InlineData(10, "tiende")]
        [InlineData(11, "elfde")]
        [InlineData(12, "twaalfde")]
        [InlineData(13, "dertiende")]
        [InlineData(14, "veertiende")]
        [InlineData(15, "vijftiende")]
        [InlineData(16, "zestiende")]
        [InlineData(17, "zeventiende")]
        [InlineData(18, "achttiende")]
        [InlineData(19, "negentiende")]
        [InlineData(20, "twintigste")]
        [InlineData(21, "eenentwintigste")]
        [InlineData(22, "tweeëntwintigste")]
        [InlineData(30, "dertigste")]
        [InlineData(40, "veertigste")]
        [InlineData(50, "vijftigste")]
        [InlineData(60, "zestigste")]
        [InlineData(70, "zeventigste")]
        [InlineData(80, "tachtigste")]
        [InlineData(90, "negentigste")]
        [InlineData(95, "vijfennegentigste")]
        [InlineData(96, "zesennegentigste")]
        [InlineData(100, "honderdste")]
        [InlineData(101, "honderdeerste")]
        [InlineData(106, "honderdzesde")]
        [InlineData(108, "honderdachtste")]
        [InlineData(112, "honderdtwaalfde")]
        [InlineData(120, "honderdtwintigste")]
        [InlineData(121, "honderdeenentwintigste")]
        [InlineData(1000, "duizendste")]
        [InlineData(1001, "duizend eerste")]
        [InlineData(1005, "duizend vijfde")]
        [InlineData(1008, "duizend achtste")]
        [InlineData(1012, "duizend twaalfde")]
        [InlineData(1021, "duizend eenentwintigste")]
        [InlineData(10000, "tienduizendste")]
        [InlineData(10121, "tienduizend honderdeenentwintigste")]
        [InlineData(100000, "honderdduizendste")]
        [InlineData(100001, "honderdduizend eerste")]
        [InlineData(1000000, "een miljoenste")]
        [InlineData(1000001, "een miljoen eerste")]
        public void ToOrdinalWords(int number, string words) =>
            Assert.Equal(words, number.ToOrdinalWords());
    }
}