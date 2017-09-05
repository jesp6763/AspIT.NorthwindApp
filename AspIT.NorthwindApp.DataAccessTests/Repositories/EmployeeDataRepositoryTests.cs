using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspIT.NorthwindApp.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.NorthwindApp.DataAccessTests.Repositories
{
    [TestClass()]
    class EmployeeDataRepositoryTests
    {
        [TestMethod()]
        public void SaveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}
/*
Reglen er: 1 Test class tester 1 class.
Så hvis du har en class EmployeeDataRepository der skal Unit Testes, skal du lave en test class der hedder EmployeeDataRepositoryTests.
Den skal indeholde en hel del test methods, så vi får god "code coverage".
Der skal testes på om constructoren virker - her skal der laves en test method ConstructorSuccess - og en modsvarende test, hvis der genereres en exception, ConstructorFailsOnException.
Sørg for at overholde triple A (Arrange, Act, Assert) - og sørg for at 1 test ikke er afhængig af udfaldet af andre tests. 
 */
