using System;
using Microsoft.AspNetCore.Mvc;
using src.SimpleAPI.Controllers;
using Xunit;


namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
                        
        
        CommandsController controller = new CommandsController();
        [Fact]
        public void ShouldReturnMyName()
        {
            var actual = controller.GetCommandById(1);
            
            Assert.Equal("Something else", actual.Value);
        }

        
    }
}
