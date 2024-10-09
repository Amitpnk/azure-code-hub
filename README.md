# Azure code hub

This repository contains a comprehensive set of sample code, tutorials, and examples for various Azure services. It serves as a resource for developers to learn and implement Azure services in their projects.

## Table of Contents

- [Introduction](#introduction)
- [Services Covered](#services-covered)
- [Prerequisites](#prerequisites)
- [Folder Structure](#folder-structure)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This repository provides examples and best practices for working with a wide range of Azure services, including compute, storage, networking, security, and more. Whether you're new to Azure or an experienced developer, this collection aims to help you integrate Azure services into your applications.

## Prerequisites

Before you begin, ensure you have the following:

- An [Azure account](https://azure.microsoft.com/en-us/free/).
- [Azure CLI](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli-windows?tabs=azure-cli) installed on your local machine.
- Basic knowledge of Azure services and cloud computing.

## Services Covered

Below is a list of Azure services covered in this repository. Click on each service to explore the relevant samples and implementations.

### Authentication
- [ ] Azure Active Directory
- [ ] Azure AD B2C

### Compute
- [ ] Azure Functions
- [ ] Azure App Service
- [ ] Azure Virtual Machines
- [ ] Azure Container Instances

### Data
- [ ] Azure SQL
- [ ] Azure Cosmos DB
- [ ] Azure Storage
  - [ ] Blobs
  - [ ] Tables
  - [ ] Queues
- [ ] Azure Data Lake

### Networking
- [ ] Azure Virtual Network
- [ ] Azure Load Balancer
- [ ] Azure Application Gateway

### Security
- [x] Azure Key Vault
- [ ] Azure Security Center
- [ ] Azure Policy

### Monitoring
- [ ] Azure Monitor
- [ ] Azure Log Analytics
- [ ] Azure Application Insights

## Folder Structure

The repository is organized into the following structure:

```
azure-code-hub/
│
├── authentication/
│   ├── azure-active-directory/
│   ├── azure-ad-b2c/
│
├── compute/
│   ├── azure-functions/
│   ├── azure-app-service/
│   ├── azure-virtual-machines/
│   └── azure-container-instances/
│
├── data/
│   ├── azure-sql/
│   ├── azure-cosmos-db/
│   ├── azure-storage/
│   └── azure-data-lake/
│
├── networking/
│   ├── azure-virtual-network/
│   ├── azure-load-balancer/
│   └── azure-application-gateway/
│
├── security/
│   ├── azure-key-vault/
│   ├── azure-security-center/
│   └── azure-policy/
│
└── monitoring/
    ├── azure-monitor/
    ├── azure-log-analytics/
    └── azure-application-insights/
```

Each folder contains sample projects and code related to specific Azure services.

## Usage

To use the code samples in this repository:

1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/azure-code-hub.git
   cd azure-code-hub
   ```

2. Navigate to the desired service folder:
   ```sh
   cd compute/azure-functions/sample1
   ```

## Cheat code comparing to other provider 

| Category            | Microsoft Azure                                                                 | Amazon Web Services (AWS)                                                           | Google Cloud Platform (GCP)                                                      |
|----|----|----|----|
| Compute             | Azure Virtual Machines (VMs), Azure Functions, Azure Kubernetes Service | Amazon EC2, AWS Lambda, Amazon ECS, Amazon EKS                         | Google Compute Engine, Cloud Functions, Google Kubernetes Engine (GKE)   |
| Storage             | Azure Blob Storage, Azure Files, Azure Disk Storage                     | Amazon S3, Amazon EFS, Amazon Elastic Block Store (EBS)                    | Google Cloud Storage, Persistent Disk, Filestore                         |
| Database            | Azure SQL Database, Cosmos DB, Azure Database for PostgreSQL/MySQL      | Amazon RDS, Amazon DynamoDB, Amazon Aurora, Amazon Redshift            | Cloud SQL, Cloud Spanner, Firestore, Bigtable                        |
| Networking          | Azure Virtual Network, Azure CDN, Azure DNS                             | Amazon VPC, Amazon CloudFront, Route 53                                    | Virtual Private Cloud (VPC), Cloud CDN, Cloud DNS                        |
| AI & ML             | Azure Machine Learning, Cognitive Services                                  | Amazon SageMaker, AWS Deep Learning AMIs, Comprehend, Rekognition      | AI Platform, AutoML, Cloud Vision API, Natural Language API          |
| Serverless          | Azure Functions, Logic Apps                                                 | AWS Lambda, AWS Step Functions                                                 | Cloud Functions, Cloud Run                                                   |
| IoT                 | Azure IoT Hub, Azure IoT Central                                            | AWS IoT Core, AWS Greengrass                                                   | Cloud IoT Core                                                                  |
| Big Data & Analytics| Azure Synapse Analytics, Azure HDInsight, Azure Data Lake Analytics     | Amazon EMR, Amazon Athena, Amazon Kinesis                                  | BigQuery, Dataflow, Dataproc                                             |
| DevOps              | Azure DevOps, GitHub Actions, Azure Pipelines                           | AWS CodePipeline, AWS CodeBuild, AWS CodeDeploy                            | Cloud Build, Cloud Source Repositories, Cloud Deployment Manager          |
| Global Reach        | 70+ regions, 140+ countries                                                         | 32 regions, 99 Availability Zones                                                      | 38 regions, 200+ countries                                                          |
| Hybrid Cloud        | Azure Arc, Azure Stack                                                      | AWS Outposts, VMware Cloud on AWS                                              | Anthos, Bare Metal Solution                                                  |
| Security            | Azure Security Center, Azure Sentinel, Azure Key Vault                  | AWS Security Hub, AWS Shield, AWS KMS                                      | Cloud Security Command Center (SCC), Cloud Armor, Cloud KMS              |
| Pricing             | Pay-as-you-go, Reserved Instances, Spot Pricing                                     | Pay-as-you-go, Reserved Instances, Spot Instances                                      | Pay-as-you-go, Sustained Use Discounts, Committed Use Contracts                      |
| Compliance          | 90+ compliance offerings, including HIPAA, GDPR, ISO                                | 100+ compliance offerings, including HIPAA, GDPR, ISO                                 | 70+ compliance certifications, including HIPAA, GDPR, ISO                            |
| Support & Ecosystem | Comprehensive support plans, strong ecosystem with GitHub integration               | Extensive support options, large partner network                                       | Flexible support options, strong integration with Google services                    |

## Contributing

Contributions are welcome! If you have a new sample or an improvement to an existing one, please follow these steps:

1. Fork this repository.
2. Create a new branch with a descriptive name.
3. Make your changes and commit them.
4. Push your changes to your fork.
5. Create a pull request against the main branch of this repository.

Please ensure your contributions align with the coding standards and best practices.

## License

This repository is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
