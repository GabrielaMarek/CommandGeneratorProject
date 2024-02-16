# Minecraft Command Generator

This project is a web application that allows users to generate Minecraft commands for various actions, such as giving items to players. Users can specify the type of command, player name, item, quantity, and enchantments.

## Features

- **Command Generation**: Users can generate Minecraft commands by selecting options such as command type, player name, item, quantity, and enchantments.
- **Enchantments**: The application supports adding enchantments to items, with options to toggle enchantments and specify their levels.
- **Comments**: Users can leave comments on the application, providing feedback or suggestions.

## Technologies Used

- **ASP.NET MVC**: The web application is built using the ASP.NET MVC framework.
- **Entity Framework**: Entity Framework is used for database interaction, allowing storage of enchantment and comment data.
- **jQuery**: jQuery is used for client-side interactions and AJAX requests.
- **Bootstrap**: Bootstrap is used for styling and layout of the web application.

## Setup

1. **Clone the Repository**: Clone the repository to your local machine using the following command:
```bash
git clone https://github.com/yourusername/your-repository.git
```

2. **Database Configuration**: Update the connection string in `Web.config` file to point to your database server.

3. **Database Migration**: Run Entity Framework migrations to create and seed the database:
 ```bash
   Update-Database
```
4. **Run the Application**: Run the application using Visual Studio or your preferred development environment.

## Usage

1. **Generate Command**: Fill out the form on the web application to specify the desired parameters for the Minecraft command, then click "Generate Command" to see the generated command.

2. **Toggle Enchantments**: Optionally toggle enchantments to add them to the command, specifying the level for each enchantment if desired.

3. **Leave Comments**: Users can leave comments on the application by filling out the comment form and submitting it.

## Contributing

Contributions are welcome! If you'd like to contribute to the project, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature-name`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to the branch (`git push origin feature/your-feature-name`).
6. Create a new Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
