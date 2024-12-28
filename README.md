# Accessing Disposed Object in C#

This repository demonstrates a common error in C#: attempting to access an object after it has been disposed of using a `using` statement.  The example uses a database context, but the principle applies to any disposable object.

The `bug.cs` file contains the erroneous code. The `bugSolution.cs` file shows how to avoid the error.

## Running the Code

You will need to have a database set up and configured.  Replace placeholders like `MyDbContext` and `SomeTable` with your actual database context and table names.

## License

This project is licensed under the MIT License - see the LICENSE file for details.