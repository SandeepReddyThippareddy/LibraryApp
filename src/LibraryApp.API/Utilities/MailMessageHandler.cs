using LibraryApp.Models;

namespace LibraryApp.Utilities
{
    public static class MailMessageHandler
    {
        // 1. User Registration with Email Confirmation
        public static string GetHtmlTemplateForUserRegistration(AppUser user, string confirmationLink)
        {
            string template = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            text-align: center;
            color: #333333;
        }

        .container {
            max-width: 600px;
            margin: 20px auto;
            background-color: #ffffff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            color: #004080;
            margin-bottom: 20px;
        }

        p {
            color: #666666;
            margin-bottom: 10px;
        }

        .banner {
            width: 100%;
            max-height: 150px;
            object-fit: cover;
            border-radius: 10px 10px 0 0;
        }

        .content {
            padding: 20px;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            font-size: 16px;
            text-decoration: none;
            background-color: #004080;
            color: white;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <img src=""https://example.com/library-banner.jpg"" alt=""Banner Image"" class=""banner"">
    <div class=""container"">
        <div class=""content"">
            <h1>Welcome to Our Library!</h1>
            <p>Dear {{UserName}},</p>
            <p>Thank you for registering with our library. Please confirm your email address by clicking the button below.</p>
            <a href=""{{ConfirmationLink}}"" class=""button"">Confirm Email</a>
        </div>
    </div>
</body>
</html>";

            template = template.Replace("{{UserName}}", user.DisplayName);
            template = template.Replace("{{ConfirmationLink}}", confirmationLink);

            return template;
        }

        // 2. Book Borrowing Confirmation
        public static string GetHtmlTemplateForBookBorrowing(AppUser user, Book book, DateTime dueDate)
        {
            string template = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            text-align: center;
            color: #333333;
        }

        .container {
            max-width: 600px;
            margin: 20px auto;
            background-color: #ffffff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            color: #004080;
            margin-bottom: 20px;
        }

        p {
            color: #666666;
            margin-bottom: 10px;
        }

        .banner {
            width: 100%;
            max-height: 150px;
            object-fit: cover;
            border-radius: 10px 10px 0 0;
        }

        .content {
            padding: 20px;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            font-size: 16px;
            text-decoration: none;
            background-color: #004080;
            color: white;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <img src=""https://example.com/library-banner.jpg"" alt=""Banner Image"" class=""banner"">
    <div class=""container"">
        <div class=""content"">
            <h1>Book Borrowed Confirmation</h1>
            <p>Dear {{UserName}},</p>
            <p>You have successfully borrowed the following book from our library:</p>
            <p><strong>Book Title:</strong> {{BookTitle}}</p>
            <p><strong>Due Date:</strong> {{DueDate}}</p>
            <p>Please ensure to return the book on or before the due date.</p>
        </div>
    </div>
</body>
</html>";

            template = template.Replace("{{UserName}}", user.DisplayName);
            template = template.Replace("{{BookTitle}}", book.Title);
            template = template.Replace("{{DueDate}}", dueDate.ToString("MMMM dd, yyyy"));

            return template;
        }

        // 3. Book Return Reminder
        public static string GetHtmlTemplateForBookReturnReminder(AppUser user, Book book, DateTime dueDate)
        {
            string template = @"
<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            text-align: center;
            color: #333333;
        }

        .container {
            max-width: 600px;
            margin: 20px auto;
            background-color: #ffffff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            color: #d9534f;
            margin-bottom: 20px;
        }

        p {
            color: #666666;
            margin-bottom: 10px;
        }

        .banner {
            width: 100%;
            max-height: 150px;
            object-fit: cover;
            border-radius: 10px 10px 0 0;
        }

        .content {
            padding: 20px;
        }

        .button {
            display: inline-block;
            padding: 10px 20px;
            font-size: 16px;
            text-decoration: none;
            background-color: #d9534f;
            color: white;
            border-radius: 5px;
        }
    </style>
</head>
<body>
    <img src=""https://example.com/library-banner.jpg"" alt=""Banner Image"" class=""banner"">
    <div class=""container"">
        <div class=""content"">
            <h1>Book Return Reminder</h1>
            <p>Dear {{UserName}},</p>
            <p>This is a reminder that the following book is due for return soon:</p>
            <p><strong>Book Title:</strong> {{BookTitle}}</p>
            <p><strong>Due Date:</strong> {{DueDate}}</p>
            <p>Please make sure to return the book on or before the due date to avoid late fees.</p>
        </div>
    </div>
</body>
</html>";

            template = template.Replace("{{UserName}}", user.DisplayName);
            template = template.Replace("{{BookTitle}}", book.Title);
            template = template.Replace("{{DueDate}}", dueDate.ToString("MMMM dd, yyyy"));

            return template;
        }
    }
}
