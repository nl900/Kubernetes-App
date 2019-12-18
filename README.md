A simple ASP.NET web app outputting host environment information to the browser.
The Helm chart deploys 3 instances of the app to a single-node Kubernetes cluster run locally on your machine.

### Requirements
Minikube</br>
kubectl CLI</br>
Helm</br>

### To run
Download the kubernetesapp-chart directory</br>
cd into the directory

> helm install kubernetesapprelease ./kubernetesapp-chart/

Check deployments on the kubernetes cluster
> kubectl get all --selector app=kubernetesapp

> kubectl port-forward service/kubernetesapprelease-service 9999:8888

Navigate to localhost:9999

