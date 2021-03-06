using Xunit;
using CoinComboMaker.Objects;
using System;
using System.Collections.Generic;

namespace CoinComboMaker
{
  public class CoinComboTest
  {
    [Fact]
    public void MakeChange_ForOneReturnsOnePenny_onePenny()
    {
      //arrange
      int inputtedNumber = 1;
      CoinCombo testCoinCombo = new CoinCombo(inputtedNumber);

      //act
      Dictionary<string, int> output = testCoinCombo.MakeChange();

      //assert
      Dictionary<string, int> testNumber = new Dictionary<string, int>{};
      testNumber.Add("quarters", 0);
      testNumber.Add("dimes", 0);
      testNumber.Add("nickels", 0);
      testNumber.Add("pennies", 1);

      Assert.Equal(testNumber, output);
    }

    [Fact]
    public void MakeChange_ForFiveReturnsOneNickel_oneNickel()
    {
      //arrange
      int inputtedNumber = 5;
      CoinCombo testCoinCombo = new CoinCombo(inputtedNumber);

      //act
      Dictionary<string, int> output = testCoinCombo.MakeChange();

      //assert
      Dictionary<string, int> testNumber = new Dictionary<string, int>{};
      testNumber.Add("quarters", 0);
      testNumber.Add("dimes", 0);
      testNumber.Add("nickels", 1);
      testNumber.Add("pennies", 0);

      Assert.Equal(testNumber, output);
    }

    [Fact]
    public void MakeChange_ForTenReturnsOneDime_oneDime()
    {
      //arrange
      int inputtedNumber = 10;
      CoinCombo testCoinCombo = new CoinCombo(inputtedNumber);

      //act
      Dictionary<string, int> output = testCoinCombo.MakeChange();

      //assert
      Dictionary<string, int> testNumber = new Dictionary<string, int>{};
      testNumber.Add("quarters", 0);
      testNumber.Add("dimes", 1);
      testNumber.Add("nickels", 0);
      testNumber.Add("pennies", 0);

      Assert.Equal(testNumber, output);
    }

    [Fact]
    public void MakeChange_ForTwentyFiveReturnsOneQuarter_oneQuarter()
    {
      //arrange
      int inputtedNumber = 25;
      CoinCombo testCoinCombo = new CoinCombo(inputtedNumber);

      //act
      Dictionary<string, int> output = testCoinCombo.MakeChange();

      //assert
      Dictionary<string, int> testNumber = new Dictionary<string, int>{};
      testNumber.Add("quarters", 1);
      testNumber.Add("dimes", 0);
      testNumber.Add("nickels", 0);
      testNumber.Add("pennies", 0);

      Assert.Equal(testNumber, output);
    }

    [Fact]
    public void MakeChange_ForFiftyReturnsTwoQuarters_twoQuarters()
    {
      //arrange
      int inputtedNumber = 50;
      CoinCombo testCoinCombo = new CoinCombo(inputtedNumber);

      //act
      Dictionary<string, int> output = testCoinCombo.MakeChange();

      //assert
      Dictionary<string, int> testNumber = new Dictionary<string, int>{};
      testNumber.Add("quarters", 2);
      testNumber.Add("dimes", 0);
      testNumber.Add("nickels", 0);
      testNumber.Add("pennies", 0);

      Assert.Equal(testNumber, output);
    }

    [Fact]
    public void MakeChange_ForTwentyReturnsTwoDimes_twoDimes()
    {
      //arrange
      int inputtedNumber = 20;
      CoinCombo testCoinCombo = new CoinCombo(inputtedNumber);

      //act
      Dictionary<string, int> output = testCoinCombo.MakeChange();

      //assert
      Dictionary<string, int> testNumber = new Dictionary<string, int>{};
      testNumber.Add("quarters", 0);
      testNumber.Add("dimes", 2);
      testNumber.Add("nickels", 0);
      testNumber.Add("pennies", 0);

      Assert.Equal(testNumber, output);
    }

    [Fact]
    public void MakeChange_ForFourReturnsFourPennies_fourPennies()
    {
      //arrange
      int inputtedNumber = 4;
      CoinCombo testCoinCombo = new CoinCombo(inputtedNumber);

      //act
      Dictionary<string, int> output = testCoinCombo.MakeChange();

      //assert
      Dictionary<string, int> testNumber = new Dictionary<string, int>{};
      testNumber.Add("quarters", 0);
      testNumber.Add("dimes", 0);
      testNumber.Add("nickels", 0);
      testNumber.Add("pennies", 4);

      Assert.Equal(testNumber, output);
    }

    [Fact]
    public void MakeChange_ForRandomCentAmountReturnsAppropriateCoins_appropriateCoins()
    {
      //arrange
      int inputtedNumber = 69;
      CoinCombo testCoinCombo = new CoinCombo(inputtedNumber);

      //act
      Dictionary<string, int> output = testCoinCombo.MakeChange();

      //assert
      Dictionary<string, int> testNumber = new Dictionary<string, int>{};
      testNumber.Add("quarters", 2);
      testNumber.Add("dimes", 1);
      testNumber.Add("nickels", 1);
      testNumber.Add("pennies", 4);

      Assert.Equal(testNumber, output);
    }
  }
}
