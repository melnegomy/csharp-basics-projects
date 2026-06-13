# 🎯 Quiz Game Project

A simple console-based quiz game built with C# that asks users a series of questions, validates their answers, calculates the final score, and demonstrates basic exception handling.

## 🚀 Features

* ❓ Ask multiple quiz questions
* ✅ Validate user answers
* 📊 Calculate the final score
* ⚠️ Handle invalid or empty input using exceptions
* 🎮 Interactive console experience

## 📚 Concepts Demonstrated

### 🗂️ Arrays

Store questions and answers using arrays:

```csharp
string[] questions
string[] answers
```

### 🔄 Loops

Use a `for` loop to iterate through all quiz questions.

### 🎯 Methods

Separate logic into reusable methods:

```csharp
IsTheAnswerCorrect()
```

### ⚠️ Exception Handling

Handle invalid user input using:

```csharp
try
catch
throw
```

### 📥 User Input

Read answers from the console and compare them with the expected answers.

## 🛠️ Technologies

* 💻 C#
* ⚙️ .NET
* 🧰 Visual Studio

## 📂 Project Structure

```text
QuizGameProject/
│
├── Main()
└── IsTheAnswerCorrect()
```

## 🎮 How It Works

1. The game displays a question.
2. The user enters an answer.
3. The program checks whether the answer is correct.
4. The score is updated.
5. After all questions are answered, the final score is displayed.

## 📋 Example Output

```text
Welcome to my game
--------------------
Let's answer the questions

1. What is the capital of Egypt?
> Cairo

The Answer Is True

--------------------
Your Score Is 3 of 3
Thank You For Playing
```

## 🎓 Learning Outcomes

Through this project, you will practice:

* Arrays
* Methods
* Loops
* Conditional Statements
* Exception Handling
* User Input Validation
* Console Application Development

## 🔧 Future Improvements

* Add multiple-choice questions
* Randomize question order
* Add difficulty levels
* Load questions from a file or database
* Implement timers for each question
* Store high scores
* Use Classes and OOP design

## 👨‍💻 Author

Mohamed Elnegomy

---

⭐ If you found this project useful, consider giving the repository a star.
