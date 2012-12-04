﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using UglyTrivia;

namespace Trivia.Tests
{
    [TestFixture]
    class TriviaTests
    {
        [Test]
        public void Should_ask_question_when_player_is_not_in_penalty_box()
        {
            var game = new FakeGame();
            game.add("Andreas");
            game.roll(1);

            //How to test if player was asked a question?
            Assert.That(game.AskQuestionCalled, Is.True);
        }

        private class FakeGame : Game
        {
            public bool AskQuestionCalled { get; set; }
            protected override void askQuestion()
            {
                AskQuestionCalled = true;
                base.askQuestion();
            }
        }
    }
}
