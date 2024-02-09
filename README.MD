# FileShare Project

Welcome to the FileShare project! This interactive guide will help you set up and use the FileShare application on your local machine.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [Visual Studio](https://visualstudio.microsoft.com/downloads/)
- [MySQL Server](https://dev.mysql.com/downloads/)

### Installation

1. **Clone the Repository:** 
   - Open a terminal.
   - Run the following command:

     ```bash
     git clone https://github.com/MrJi421/fileshare.git
     ```

2. **Open Project in Visual Studio:**
   - Open Visual Studio.
   - Navigate to the folder where you cloned the repository and open the solution file (`FileShare.sln`).

3. **Set up MySQL Database:**
   - Execute the provided SQL scripts (found in the "Database" folder) to set up the MySQL database.
   - Update the connection strings in the code to match your MySQL database credentials.

4. **Build and Run:**
   - Build the solution.
   - Run the application.

## Usage

Once the application is running, you can:

- Log in with your credentials.
- Share files with other users.
- View shared files and download them.

## Configuration

To configure the application:

- Update the `app.config` file with your MySQL connection string.

## Contributing

If you'd like to contribute to the project:

1. Fork the repository.
2. Create a new branch for your feature (`git checkout -b feature/your-feature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/your-feature`).
5. Open a pull request.

## License

This project is licensed under the Apache License. See the [LICENSE](LICENSE.md) file for details.

## Acknowledgments

- Special thanks to [contributors](CONTRIBUTORS.md) for their contributions.
- Credits to any third-party libraries or resources used in the project.

Enjoy using FileShare! If you encounter any issues or have suggestions, feel free to open an issue on GitHub.
