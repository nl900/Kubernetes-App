A simple ASP.NET web app outputting host environment information to the browser.

### Requirements
Minikube</br>
kubectl CLI</br>
Helm</br>

### To run
Download the kubernetesapp-chart directory
cd into the directory

> helm install kubernetesapprelease ./kubernetesapp-chart/

Check deployments on the kubernetes cluster
> kubectl get all --selector app=kubernetesapp

