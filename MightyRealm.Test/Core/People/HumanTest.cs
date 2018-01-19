using System;
using System.Collections.Generic;
using MightyRealm.Core.People;
using MightyRealm.Core.Stats;
using MightyRealm.Helpers.Enum.People;
using Xunit;

namespace MightyRealm.Test
{
    public class HumanTest
    {
        private readonly Human _human; 
        
        public HumanTest()
        {
            _human = new Human
            {
                Id = 1,
                Attributeses = new List<IStat>
                {
                    new Intelligence
                    {
                        Amount = 90
                    },
                    new Dexterity
                    {
                        Amount = 20
                    }
                }
                
            };
        }
        [Fact]
        public void CanGetStats()
        {
            var intelligence = _human.CurrentIntelligence;
            var strength = _human.CurrentStrength;
            var dexterity = _human.CurrentDexterity;
            Assert.Equal(90, intelligence);
            Assert.Equal(20, dexterity);
            Assert.Equal(0, strength);
        }
    }
}