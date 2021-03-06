﻿using System;

namespace SainaYar.Matchmaking.Core.Model
{
    public class ResultScore
    {
        public Guid Id { get; private set; }
        public Guid PlayerId { get; private set; }
        public double PointsTaken { get; private set; }
        public double PointLost { get; private set; }

        public int RoundsWon { get; private set; }
        public int RoundsLost { get; private set; }

        public ResultScore(Guid id, Guid playerId, int roundsWon, int roundsLost, double pointsTaken, double pointLost)
        {
            Id = id;
            PlayerId = playerId;
            RoundsWon = roundsWon;
            RoundsLost = roundsLost;
            PointsTaken = pointsTaken;
            PointLost = pointLost;
        }
    }
}