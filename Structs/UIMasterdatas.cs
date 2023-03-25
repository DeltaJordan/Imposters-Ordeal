﻿using System;
using System.Collections.Generic;
using System.Numerics;

namespace ImpostersOrdeal
{
    public static class UIMasterdatas
	{
		public class PokemonIcon : ICloneable, IComparable<PokemonIcon>
		{
			public int uniqueID;
			public string assetBundleName;
			public string assetName;
			public string assetBundleNameLarge;
			public string assetNameLarge;
			public string assetBundleNameDP;
			public string assetNameDP;
			public Vector2 hallofFameOffset;

            public object Clone()
            {
				return this.MemberwiseClone();
            }

            public int CompareTo(PokemonIcon other)
            {
                return uniqueID.CompareTo(other.uniqueID);
            }
        }

		public class AshiatoIcon : ICloneable, IComparable<AshiatoIcon>
		{
			public int uniqueID;
			public string sideIconAssetName;
			public string bothIconAssetName;

            public object Clone()
            {
				return this.MemberwiseClone();
			}

			public int CompareTo(AshiatoIcon other)
			{
				return uniqueID.CompareTo(other.uniqueID);
			}
		}

		public class PokemonVoice : ICloneable, IComparable<PokemonVoice>
		{
			public int uniqueID; 
			public string wwiseEvent;
			public string stopEventId;
			public Vector3 centerPointOffset;
			public bool rotationLimits;
			public Vector2 rotationLimitAngle;

            public object Clone()
            {
				return this.MemberwiseClone();
			}

			public int CompareTo(PokemonVoice other)
			{
				return uniqueID.CompareTo(other.uniqueID);
			}
		}

		public class ZukanDisplay : ICloneable, IComparable<ZukanDisplay>
		{
			public int uniqueID;
			public Vector3 moveLimit;
			public Vector3 modelOffset;
			public Vector2 modelRotationAngle;

            public object Clone()
            {
				return this.MemberwiseClone();
			}

			public int CompareTo(ZukanDisplay other)
			{
				return uniqueID.CompareTo(other.uniqueID);
			}
		}

		public class ZukanCompareHeight : ICloneable, IComparable<ZukanCompareHeight>
		{
			public int uniqueID;
			public float playerScaleFactor;
			public Vector3 playerOffset; 
			public Vector2 playerRotationAngle;

            public object Clone()
            {
				return this.MemberwiseClone();
			}

			public int CompareTo(ZukanCompareHeight other)
			{
				return uniqueID.CompareTo(other.uniqueID);
			}
		}

		public class SearchPokeIconSex : ICloneable, IComparable<SearchPokeIconSex>
        {
			public int monsNo;
			public int sex;

            public object Clone()
			{
				return this.MemberwiseClone();
			}

            public int CompareTo(SearchPokeIconSex other)
			{
				if (monsNo == other.monsNo)
					return 0;
				if (monsNo == GlobalData.gameData.dexEntries.Count)
					return -1;
				if (other.monsNo == GlobalData.gameData.dexEntries.Count)
					return 1;
				return monsNo.CompareTo(other.monsNo);
			}
        }

		public class DistributionTable
		{
			public List<DistributionEntry> diamondFieldTable;
            public List<DistributionEntry> diamondDungeonTable;
            public List<DistributionEntry> pearlFieldTable;
            public List<DistributionEntry> pearlDungeonTable;
        }

		public class DistributionEntry : ICloneable
		{
			public int[] beforeMorning;
            public int[] beforeDaytime;
            public int[] beforeNight;
            public int[] afterMorning;
            public int[] afterDaytime;
            public int[] afterNight;
            public int[] fishing;
            public int[] pokemonTraser;
            public int[] honeyTree;

			public object Clone() => new DistributionEntry()
			{
				beforeMorning = (int[])beforeMorning.Clone(),
				beforeDaytime = (int[])beforeDaytime.Clone(),
				beforeNight = (int[])beforeNight.Clone(),
				afterMorning = (int[])afterMorning.Clone(),
				afterDaytime = (int[])afterDaytime.Clone(),
				afterNight = (int[])afterNight.Clone(),
                fishing = (int[])fishing.Clone(),
                pokemonTraser = (int[])pokemonTraser.Clone(),
                honeyTree = (int[])honeyTree.Clone()
            };
        }
	}
}