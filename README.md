# EduSpark - Learning Management System (LMS) API

[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2019+-red.svg)](https://www.microsoft.com/en-us/sql-server)
[![Stripe](https://img.shields.io/badge/Stripe-API-purple.svg)](https://stripe.com/)
[![Entity Framework Core](https://img.shields.io/badge/EF%20Core-8.0-green.svg)](https://docs.microsoft.com/en-us/ef/)
[![Postman](https://img.shields.io/badge/Postman-API-orange.svg)](https://www.postman.com/)
[![Swagger](https://img.shields.io/badge/Swagger-UI-yellow.svg)](https://swagger.io/)
[![AutoMapper](https://img.shields.io/badge/AutoMapper-12.0-lightblue.svg)](https://automapper.org/)

[![Serilog](https://img.shields.io/badge/Serilog-Logging-darkgreen.svg)](https://serilog.net/)
[![SendGrid](https://img.shields.io/badge/SendGrid-Email-blue.svg)](https://sendgrid.com/)
[![Health Check](https://img.shields.io/badge/Health%20Check-Healthy-brightgreen.svg)](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks)

[![Azure](https://img.shields.io/badge/Azure-Cloud-0078d4.svg)](https://azure.microsoft.com/)
[![Azure AD B2C](https://img.shields.io/badge/Azure%20AD%20B2C-Identity-0078d4.svg)](https://azure.microsoft.com/en-us/services/active-directory-b2c/)
[![Azure SQL](https://img.shields.io/badge/Azure%20SQL-Database-0078d4.svg)](https://azure.microsoft.com/en-us/services/sql-database/)
[![Azure Blob Storage](https://img.shields.io/badge/Azure%20Blob%20Storage-Storage-0078d4.svg)](https://azure.microsoft.com/en-us/services/storage/blobs/)
[![Azure Functions](https://img.shields.io/badge/Azure%20Functions-Serverless-0078d4.svg)](https://azure.microsoft.com/en-us/services/functions/)

[![Azure DevOps](https://img.shields.io/badge/Azure%20DevOps-CI/CD-0078d4.svg)](https://azure.microsoft.com/en-us/services/devops/)
[![Azure Web App](https://img.shields.io/badge/Azure%20Web%20App-Hosting-0078d4.svg)](https://azure.microsoft.com/en-us/services/app-service/web/)
[![Application Insights](https://img.shields.io/badge/Application%20Insights-Monitoring-0078d4.svg)](https://azure.microsoft.com/en-us/services/monitor/)
[![Angular](https://img.shields.io/badge/Angular-18-DD0031.svg)](https://angular.io/)


## 🚀 Project Overview

EduSpark is a comprehensive Learning Management System (LMS) designed to simplify and enhance the online education experience for both students and instructors. The platform enables educators to create and manage courses effortlessly while providing students with an intuitive interface to browse, enroll in, and complete courses at their own pace.

## 🔄 Application Workflow

### 1. 🔐 Authentication & Authorization
- Users authenticate via **Azure AD B2C** for secure access
- System automatically reads **UserRole** to determine access permissions
- Supports three user roles: **Admin**, **Instructor**, and **Student**

### 2. 📚 Course Management (Instructor)
- Instructors create and manage comprehensive course content
- **Course Creation**: Select category, set pricing, configure seat availability, and schedule dates
- **Session Management**: Upload video sessions with ordered content using `VideoOrder` for structured learning paths
- **Content Organization**: Organize materials with titles, descriptions, and sequential ordering

### 3. 🔍 Course Discovery (Student)
- **Search Functionality**: Students can search courses by keywords or browse by category
- **Category Filtering**: Utilize course categories for efficient content discovery
- **Detailed Course View**: Access comprehensive course information including:
  - Course description and objectives
  - Pricing and enrollment details
  - Instructor biography and credentials
  - Complete session outline and curriculum

### 4. 💳 Enrollment & Payment
- **Enrollment Initiation**: Student enrollment creates a record with `"Pending"` status
- **Payment Processing**: Secure payment gateway integration via Stripe
- **Status Management**: 
  - Payment records created with `"Pending"` status
  - Gateway callbacks update status to `"Completed"` or `"Failed"`
  - Enrollment status automatically synchronized with payment confirmation
- **Transaction Security**: All payment processing handled through secure, encrypted channels

### 5. ⭐ Feedback Loop
- **Course Reviews**: Students provide ratings (1-5 stars) and detailed comments
- **Instructor Insights**: Instructors access feedback to improve course quality and content
- **Continuous Improvement**: Rating system enables quality assurance and course enhancement

### 6. 📹 Video Requests
- **Content Requests**: Any user can submit requests for specific video content
- **Instructor Response**: Instructors review, respond, and fulfill requests
- **Content Delivery**: New video URLs attached to fulfill student learning needs

## 👥 User Roles & Capabilities

### 🎓 **Student Capabilities**
- ✅ **Account Management**: Register and authenticate via Azure AD B2C
- ✅ **Course Discovery**: Browse courses by category or search with keywords
- ✅ **Course Information**: View detailed course information including:
  - Instructor biography and credentials
  - Complete session outline and curriculum
  - Pricing and seat availability
  - Course capacity and scheduling
- ✅ **Enrollment Process**: Seamless enrollment with integrated payment processing
- ✅ **Course Feedback**: Submit reviews and ratings during or after course completion
- ✅ **Content Requests**: Submit video requests for additional learning topics
- ✅ **Notifications**: Receive automated updates for:
  - Course announcements and updates
  - Payment confirmations and receipts
  - Enrollment status changes

### 👨‍🏫 **Instructor Capabilities**
- ✅ **Account Management**: Register and authenticate via Azure AD B2C
- ✅ **Profile Management**: Maintain comprehensive instructor biography
- ✅ **Course Creation & Management**: 
  - Create courses with title, type, and descriptions
  - Set pricing strategies and enrollment limits
  - Configure course dates and scheduling
  - Manage seat counts and availability
- ✅ **Content Management**: 
  - Upload session videos with sequential ordering
  - Add detailed session titles and descriptions
  - Organize content for optimal learning flow
- ✅ **Student Management**: 
  - Monitor student enrollments and engagement
  - Track payment statuses and financial metrics
  - View enrollment analytics and trends
- ✅ **Feedback Monitoring**: Access and analyze student reviews and ratings
- ✅ **Video Request Fulfillment**: 
  - Review student content requests
  - Provide responses and guidance
  - Upload new content to meet student needs

## ✨ Key Features

### 🔐 User Management
- **Secure Authentication**: Integration with Azure AD B2C for robust user registration and authentication
- **Role-Based Access**: Support for Admin, Instructor, and Student roles with appropriate permissions
- **Profile Management**: Comprehensive user profile management with bio and picture upload capabilities

### 📚 Course Management
- **Course Creation**: Instructors can create courses with multiple sessions and video content
- **Content Organization**: Structured session management with video ordering and descriptions
- **Category System**: Organized course categorization for better discoverability
- **Media Support**: Video and thumbnail upload capabilities via Azure Blob Storage

### 💳 Enrollment & Payment
- **Secure Payments**: Integration with Stripe for secure payment processing
- **Enrollment Tracking**: Complete enrollment lifecycle management
- **Payment Status**: Real-time payment status updates and confirmations

### 📧 Notifications & Communication
- **Automated Emails**: SendGrid integration for automated notifications
- **Video Requests**: Students can request specific video content from instructors
- **Contact System**: Built-in contact management for user inquiries

### 🎥 Content Delivery
- **Video Streaming**: Live and on-demand video sessions
- **Cloud Storage**: Scalable media storage using Azure Blob Storage
- **Session Management**: Ordered video content with progress tracking

### 📊 Monitoring & Analytics
- **Application Insights**: Comprehensive application performance monitoring
- **Structured Logging**: Serilog integration for detailed diagnostics
- **Health Checks**: Built-in health monitoring for system reliability

### 🔒 Security & Scalability
- **Environment Variables**: Secure management of sensitive configuration
- **Azure Hosting**: Scalable hosting on Azure Web App
- **CI/CD Pipeline**: Automated deployment via Azure DevOps

## 🏛️ Architecture

EduPlatform follows **Clean Architecture** principles, ensuring separation of concerns, maintainability, and testability.

### 📁 Project Structure

```
EduPlatform/
├── 📂 EduPlatform.Domain/          # Core business entities and domain logic
├── 📂 EduPlatform.Application/     # Business logic, services, and DTOs
├── 📂 EduPlatform.Infrastructure/  # Data access and external service implementations
└── 📂 EduPlatform.API/            # Web API controllers and presentation layer
```

### 🔄 Key Architectural Patterns

- **Repository Pattern**: Clean abstraction for data access operations
- **Unit of Work Pattern**: Coordinated transaction management across repositories
- **Service Layer**: Encapsulated business logic with dependency injection
- **Dependency Injection**: Loose coupling and improved testability

### 🌟 Benefits

- **Separation of Concerns**: Clear layer responsibilities for maintainable code
- **Testability**: Decoupled components enable comprehensive testing
- **Scalability**: Architecture supports future growth and technology integration
- **Flexibility**: Easy integration with new services and technologies

## 🛠️ Technology Stack

### Backend & Framework
- **.NET Core 9**: Modern, cross-platform application framework
- **Entity Framework Core 9**: Advanced ORM for database operations
- **AutoMapper**: Efficient object-to-object mapping

### Database & Storage
- **Azure SQL Server**: Reliable relational database management
- **Azure Blob Storage**: Scalable cloud storage for media files
- **In-Memory Caching**: High-performance data caching

### Authentication & Security
- **Azure AD B2C**: Enterprise-grade identity management
- **JWT Tokens**: Secure API authentication
- **Environment Variables**: Secure configuration management

### External Services
- **Stripe**: Secure payment processing
- **SendGrid**: Reliable email delivery service
- **Application Insights**: Application performance monitoring

### Development & Deployment
- **Azure DevOps**: CI/CD pipeline and source control
- **Azure Web App**: Managed hosting platform
- **Azure Functions**: Serverless computing for background tasks
- **Swagger**: Interactive API documentation

### Logging & Monitoring
- **Serilog**: Structured logging framework
- **Health Checks**: Application health monitoring
- **Application Insights**: Performance and usage analytics

## ⚡ Azure Functions Integration

EduPlatform leverages Azure Functions for serverless and background processing tasks, deployed separately for optimal scalability.

| Function Name | Trigger Type | Description |
|---------------|--------------|-------------|
| `SignUpValidation` | HTTP | Handles user sign-up validation logic |
| `UpdateUserProfile` | HTTP | Updates user profile information asynchronously |
| `VideoRequestTrigger` | SQL Trigger | Listens for database changes and sends confirmation emails |
| `SendVideoRequestAckEmailToUser` | HTTP | Sends acknowledgment emails for video requests |

**🔗 Azure Functions Repository**: [Education-Platform](https://github.com/safaamohamed225/Education-Platform)

## 📚 API Documentation

### 📦 Categories
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/Categories/Get-Category-By-Id/{id}` | Retrieve category by ID |
| GET | `/api/Categories/Get-All-Categories` | Retrieve all categories |

### 🎓 Courses
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/Courses/Get-All-Courses` | Retrieve all courses |
| GET | `/api/Courses/Get-All-Courses-By-Category/{categoryId}` | Retrieve courses by category |
| GET | `/api/Courses/Get-Course-Details-By-Id/{courseId}` | Retrieve detailed course information |
| POST | `/api/Courses/Create-Course` | Create a new course |
| PUT | `/api/Courses/Update-Course/{id}` | Update existing course |
| POST | `/api/Courses/Upload-Thumbnail/{courseId}` | Upload course thumbnail |
| POST | `/api/Courses/Upload-Session-Video/{sessionId}` | Upload session video |
| DELETE | `/api/Courses/Delete-Course/{id}` | Delete course |
| GET | `/api/Courses/Get-All-Instructors` | Retrieve all instructors |

### 🎟️ Enrollments
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/Enrollments/Get-Enrollment-By-Id/{enrollmentId}` | Retrieve enrollment by ID |
| GET | `/api/Enrollments/Get-User-Enrollments/{userId}` | Retrieve user's enrollments |
| GET | `/api/Enrollments/Get-Course-Enrollment/{courseId}` | Retrieve course enrollments |
| POST | `/api/Enrollments/Create-Enrollment` | Create new enrollment |
| PUT | `/api/Enrollments/Update-Enrollment/{enrollmentId}` | Update enrollment |
| DELETE | `/api/Enrollments/Delete-Enrollment/{enrollmentId}` | Delete enrollment |

### 💳 Payments
| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/api/Payments/Webhook` | Stripe payment webhook handler |

### ⭐ Reviews
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/Reviews/Get-Review-By-Id/{reviewId}` | Retrieve review by ID |
| GET | `/api/Reviews/Get-Reviews-By-Course/{courseId}` | Retrieve course reviews |
| GET | `/api/Reviews/Get-Reviews-By-User/{userId}` | Retrieve user reviews |
| POST | `/api/Reviews/Create-Review` | Create new review |
| PUT | `/api/Reviews/Update-Review/{reviewId}` | Update review |
| DELETE | `/api/Reviews/Delete-Review/{reviewId}` | Delete review |

### 👤 User Profile
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/UserProfile/Get-User-Info/{userId}` | Retrieve user information |
| PUT | `/api/UserProfile/Update-Profile-Picture` | Update profile picture |
| PUT | `/api/UserProfile/Update-Profile-Bio` | Update profile bio |

### 📹 Video Requests
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/VideoRequests/Get-All-Video-Requests` | Retrieve all video requests |
| GET | `/api/VideoRequests/Get-Video-Request-By-Id/{id}` | Retrieve video request by ID |
| GET | `/api/VideoRequests/Get-Video-Requests-By-User-Id/{userId}` | Retrieve user's video requests |
| POST | `/api/VideoRequests/Create-Video-Request` | Create new video request |
| PUT | `/api/VideoRequests/Update-Video-Request/{id}` | Update video request |
| DELETE | `/api/VideoRequests/Delete-Video-Request/{id}` | Delete video request |

### 📩 Contact & Health
| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/api/Contact/Send-Message` | Send contact message |
| GET | `/api/health` | General health check |
| GET | `/api/health/live` | Liveness probe |
| GET | `/api/health/ready` | Readiness probe |

## 📝 Request/Response Examples

### Create Course Request
```http
POST /api/Courses/Create-Course
Authorization: Bearer <your-jwt-token>
Content-Type: application/json

{
  "title": "Data Science Masterclass",
  "description": "Deep dive into Data Science using Python.",
  "price": 399.99,
  "courseType": "Online",
  "seatsAvailable": 30,
  "duration": 40,
  "categoryId": 3,
  "instructorId": 4,
  "startDate": "2025-09-10T08:00:00",
  "endDate": "2025-10-10T17:00:00",
  "sessionDetails": [
    {
      "title": "Python for Data Analysis",
      "description": "Numpy, Pandas basics",
      "videoOrder": 1
    },
    {
      "title": "Data Visualization",
      "description": "Matplotlib, Seaborn plotting",
      "videoOrder": 2
    },
    {
      "title": "Machine Learning Basics",
      "description": "Intro to Scikit-Learn",
      "videoOrder": 3
    },
    {
      "title": "Real World Projects",
      "description": "End-to-end Data Science projects",
      "videoOrder": 4
    }
  ]
}
```

### Response
```json
{
  "courseId": 44,
  "sessionIds": [50, 51, 52, 53]
}
```

## 🚀 Getting Started

### Prerequisites
- .NET 9 SDK
- Azure subscription
- SQL Server (local or Azure)
- Visual Studio 2022 or VS Code

### Installation Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/safaamohamed225/Education-Platform.git
   cd Online-Course-Platform
   ```

2. **Configure database connection**
   Update `appsettings.json` with your database connection string:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "your-connection-string-here"
     }
   }
   ```

3. **Run database migrations**
   ```bash
   dotnet ef database update
   ```

4. **Start the application**
   ```bash
   dotnet run
   ```

5. **Access the API**
   - API: `https://localhost:5001`
   - Swagger Documentation: `https://localhost:5001/swagger`

## 🔧 Configuration

### Environment Variables
Configure the following environment variables for production deployment:

```bash
CONNECTION_STRINGS__DEFAULTCONNECTION=your-database-connection
AZURE_AD_B2C__CLIENTID=your-client-id
STRIPE__SECRETKEY=your-stripe-secret-key
SENDGRID__APIKEY=your-sendgrid-api-key
AZURE_STORAGE__CONNECTIONSTRING=your-storage-connection
```

## 🧪 Testing

The project includes comprehensive unit tests using XUnit framework.

```bash
# Run all tests
dotnet test

# Run tests with coverage
dotnet test --collect:"XPlat Code Coverage"
```

## 🤝 Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🔗 Related Repositories

- **Azure Functions**: [Education-Platform](https://github.com/safaamohamed225/Education-Platform)

## 📞 Support

For support and questions:
- Create an issue in this repository
- Contact: [Through Mail](safaa.mohamed.ibrahem@gmail.com)

## 🙏 Acknowledgments

- Microsoft Azure for cloud services
- Stripe for payment processing
- SendGrid for email services
- All contributors and the open-source community

---

**Built with ❤️ by Safaa Muhammad • Powered by .NET Core & Azure**
