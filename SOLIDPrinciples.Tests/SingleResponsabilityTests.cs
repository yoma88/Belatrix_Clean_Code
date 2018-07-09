using SOLID._01_SingleResponsability;
using System;
using Xunit;

namespace SOLIDPrinciples.Tests
{
    
    public class SingleResponsabilityTests
    {
        [Fact]
        public void Validar_Suma_Correcta()
        {
            var sample = new Sample();
            sample.Sumar(5 , 6);
        }
    }
}
