- Login Azure
```
az login
```

- Create Resource Group
```
az group create --name "rg-azure-code-hub-dev" \
                --location "southeastasia" \
                --tags "Environment=Development" "Project=AzureCodeHub" "Department=SD" "ResourceType=Mixed"

```

- Create Key Vault
```
az keyvault create --resource-group "rg-azure-code-hub-dev" \
                   --name "AzureCodeHubDev" \
                   --location "southeastasia" \
                   --sku Standard \
                   --tags "Environment=Development" "Project=AzureCodeHub" "Department=SD"
```

- Creeate Service Bus Name Space
```
az servicebus namespace create -resource-group "rg-azure-code-hub-dev" \
                               --name AzureCodeHubDev \
                               --location "southeastasia" \
                               --sku Standard \
                               --tags "Environment=Development" "Project=AzureCodeHub"  "Department=SD"
```

- Create Service Bus Queues
```
az servicebus queue create -resource-group "rg-azure-code-hub-dev" \
                           --namespace-name "AzureCodeHubDev" \
                           --name AzureCodeHub_fileuploaded \
                           --max-size 1024
                           
az servicebus queue create -resource-group "rg-azure-code-hub-dev" \
                           --namespace-name "AzureCodeHubDev" \
                           --name AzureCodeHub_filedeleted \
                           --max-size 1024
```

- Create Service Bus Topics
```
az servicebus topic create -resource-group "rg-azure-code-hub-dev" \
                           --namespace-name "AzureCodeHubDev" \
                           --name topic_fileuploaded \
                           --max-size 1024
                            
 az servicebus topic create -resource-group "rg-azure-code-hub-dev" \
                            --namespace-name "AzureCodeHubDev" \
                            --name topic_filedeleted \
                            --max-size 1024
```

- Create Service Bus Subscriptions
```
az servicebus topic subscription create -resource-group "rg-azure-code-hub-dev" \
                                        --namespace-name "AzureCodeHubDev" \
                                        --topic-name topic_fileuploaded \
                                        --name sub_fileuploaded
                            
az servicebus topic subscription create -resource-group "rg-azure-code-hub-dev" \
                                        --namespace-name "AzureCodeHubDev" \
                                        --topic-name topic_filedeleted \
                                        --name sub_filedeleted
```

- Create Event Grid Domain
```
az eventgrid domain create -resource-group "rg-azure-code-hub-dev" \
                           --name AzureCodeHubDev \
                           --location "southeastasia" \
                           --sku Basic \
                           --tags "Environment=Development" "Project=AzureCodeHub"  "Department=SD"
```

- Create Event Hub Name Space
```
az eventhubs namespace create -resource-group "rg-azure-code-hub-dev" \
                              --name AzureCodeHubDev \
                              --location "southeastasia" \
                              --sku Basic \
                              --tags "Environment=Development" "Project=AzureCodeHub"  "Department=SD"
```

- Create Event Hubs
```
az eventhubs eventhub create -resource-group "rg-azure-code-hub-dev" \
                             --namespace-name "AzureCodeHubDev" \
                             --name AzureCodeHub_fileuploaded \
                             --message-retention 1 \
                             --partition-count 2
                             
az eventhubs eventhub create -resource-group "rg-azure-code-hub-dev" \
                             --namespace-name "AzureCodeHubDev" \
                             --name AzureCodeHub_filedeleted \
                             --message-retention 1 \
                             --partition-count 2
```