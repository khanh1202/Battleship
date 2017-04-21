using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;

/// <summary>
/// The AIEasyPlayer is a type of AIPlayer where it will shoot totally randomly
/// </summary>
public class AIEasyPlayer : AIPlayer
{
    public AIEasyPlayer(BattleShipsGame controller) : base(controller)
	{
    }


    protected override void GenerateCoords(ref int row, ref int column)
    {
        do
            SearchCoords(ref row, ref column);
        while
            ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid[row, column] != TileView.Sea)) ;
    }

    private void SearchCoords(ref int row, ref int column)
    {
        row = _Random.Next(0, EnemyGrid.Height);
        column = _Random.Next(0, EnemyGrid.Width);
    }


    /// <summary>
    /// ProcessShot will be called uppon when a ship is found.
    /// It will create a stack with targets it will try to hit. These targets
    /// will be around the tile that has been hit.
    /// </summary>
    /// <param name="row">the row it needs to process</param>
    /// <param name="col">the column it needs to process</param>
    /// <param name="result">the result og the last shot (should be hit)</param>
    protected override void ProcessShot(int row, int col, AttackResult result)
    {
        if (result.Value == ResultOfAttack.ShotAlready)
        {
            throw new ApplicationException("Error in AI");
        }
    }
}
