# Project Setup

## Configuration Setup

Before running the application, you must configure the required connection settings.

The project uses an external configuration file (`App.Local.config`) to store sensitive data such as:

- Database connection string
- SMTP password for email services

## Important

The default `App.config` contains placeholder values:

```xml
<configuration>
    <appSettings file="App.Local.config">
        <add key="db-connection" value="your-connection-string-here" />
        <add key="smtp-password" value="your-smtp-password-here" />
    </appSettings>
</configuration>
