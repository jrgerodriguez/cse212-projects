using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Four people are added to the queue wiith different priority, we need to dequeue the ones with highest priority first.
    // Expected Result: "John", "Bob", "Tim", "Sue"
    // Defect(s) Found: Due to a -1 in the for loop that enqueues the elements, the last element was not being included and the RemoveAt method had not been written.
    public void TestPriorityQueue_1()
    {

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 10);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 2);
        priorityQueue.Enqueue("John", 15);
        
        string[] expectedOrder = ["John", "Bob", "Tim", "Sue" ];

        for (var i = 0; i < expectedOrder.Length; i++)
        {
            string dequeued = priorityQueue.Dequeue();
            Assert.AreEqual(expectedOrder[i], dequeued);
        }
    }

    [TestMethod]
    // Scenario: People are added to a queue, the ones with the highhest priority should be removed first, if there are two or more with the same priority, the one that was added to the queue first should be dequeued.
    // Expected Result: "Erik", "John", "Bob", "Tim", "Daniel", "Sue", "Samantha"
    // Defect(s) Found: The condition was set to dequeue the one that got into the queue last so I adjusted it by removing the = sign so the index of the one that got into the queue first would not be modified.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 10);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 2);
        priorityQueue.Enqueue("John", 15);
        priorityQueue.Enqueue("Daniel", 5);
        priorityQueue.Enqueue("Samantha", 2);
        priorityQueue.Enqueue("Erik", 20);
        
        string[] expectedOrder = ["Erik", "John", "Bob", "Tim", "Daniel", "Sue", "Samantha"];

        for (var i = 0; i < expectedOrder.Length; i++) 
        {
            string dequeued = priorityQueue.Dequeue();
            Assert.AreEqual(expectedOrder[i], dequeued);
        }
    }

    // Add more test cases as needed below.
}