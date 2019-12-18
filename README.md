The Helm chart downloads the ASP.NET app from docker hub and deploys 3 instances of it to a single-node Kubernetes cluster run locally on your machine. The app shows displays the environment and host information.

### Requirements
Minikube</br>
kubectl CLI</br>
Helm</br>

### To run
Download the kubernetesapp-chart directory</br>
cd into the directory
Run the command

> helm install kubernetesapprelease ./kubernetesapp-chart/

Check deployments on the kubernetes cluster
> kubectl get all --selector app=kubernetesapp

Map local host port to Service port
> kubectl port-forward service/kubernetesapprelease-service 9999:8888

Navigate to localhost:9999
