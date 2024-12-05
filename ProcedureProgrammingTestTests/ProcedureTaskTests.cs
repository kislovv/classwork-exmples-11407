using ProcedureTestTasks;

namespace ProcedureProgrammingTestTests;

public class ProcedureTaskTests
{
    [Fact]
    public void Sent_Normalized_Emails_With_All_Unique_Values_Return_Count_Of_All()
    {
        //Aggregate
        var uniqueEmails = new []{ "test@test.com", "test2@test.com", "test3@test.com"};
        var expectedCount = uniqueEmails.Length;
        
        //Act
        var result = TaskExecutor.NumUniqueEmails(uniqueEmails);
        
        //Assert
        Assert.Equal(expectedCount, result);
    }
    
    [Fact]
    public void Sent_Emails_With_One_Duplicate_With_Dot_Return_Count_Of_All_Minus_One()
    {
        //Aggregate
        var uniqueEmails = new []
        {
            "test@test.com", "test2@test.com", "test3@test.com", "te.st@test.com"
        };
        var expectedCount = uniqueEmails.Length - 1;
        
        //Act
        var result = TaskExecutor.NumUniqueEmails(uniqueEmails);
        
        //Assert
        Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void Sent_Emails_When_One_Of_Started_With_Plus_Thrown_Exception()
    {
        var errorEmails = new [] {"+test@test.com", "test2@test.com", "test3@test.com"};
        
        Assert.Throws<Exception>(() => TaskExecutor.NumUniqueEmails(errorEmails));
    }

    [Theory]
    [InlineData(1,2)]
    [InlineData(2,5)]
    [InlineData(-1,200)]
    [InlineData(123,231)]
    [InlineData(101,202)]
    public void Test2(int a, int b)
    {
        
    }
}