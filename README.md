
An ASP.NET app is deployed to a single-node Kubernetes cluster run locally on the machine using Helm. The app displays the environment and host information it is run in.
</br>
First deploy 3 instances in development environment. Then deploy 5 instances in production environment.

### Requirements
Minikube</br>
kubectl CLI</br>
Helm 3.0.0</br>

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
You can see "appEnvironment":"development"

Stop the service and run
> helm upgrade kubernetesapprelease ./kubernetesapp-chart --values ./kubernetesapp-chart/production-values.yaml

> kubectl port-forward service/kubernetesapprelease-service 9999:8888

Navigate to localhost:9999 </br>
"appEnvironment" has changed to "production"

When finish, clean the cluster
>helm uninstall kubernetesapprelease

Stop the Minikube virtual machine
>minikube stop

Delete Minikube VM
>minikube delete

