Helm instructs via chart to pull the ASP.NET app from docker hub and deploys 3 instances of it to a single-node Kubernetes cluster run locally on your machine. The app displays the environment and host information it is run in.

### Requirements
Minikube</br>
kubectl CLI</br>
Helm</br>

### To run
Start a Kubernetes cluster
> minikube start

Download the kubernetesapp-chart directory</br>
cd into the directory</br>
Run the command

> helm install kubernetesapprelease ./kubernetesapp-chart/

Check deployments on the kubernetes cluster
> kubectl get all --selector app=kubernetesapp

Map local host port to Service port
> kubectl port-forward service/kubernetesapprelease-service 9999:8888

Navigate to localhost:9999

When finish, clean the cluster
>helm uninstall kubernetesapprelease

Stop the Minikube virtual machine
>minikube stop

Delete Minikube VM
>minikube delete

