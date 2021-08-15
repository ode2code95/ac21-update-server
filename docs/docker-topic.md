# Dolphins, Containers - A Home for Your Apps
## WHAT IS DOCKER?
Slide 1: Docker Logo:
### I. Definitions
- In a Nutshell, Docker is an ecosystem for packaging an app *and* its host environment into a consumer-ready deliverable.
- Is a containerization (not virtualization) platform.
  - Is NOT the hypervisor.
  - This makes it lightweight enough to run on any OS that supports Docker (More on this in the Scalability section.)

### II. Some advantages of the Docker ecosystem:
- Scalability
  - Docker has become the linga franca of containerization.
  - Manage your containers directly with [Docker Swarm](https://docs.docker.com/engine/swarm/) or [Kubernetes](https://kubernetes.io/), with [Portainer](https://www.portainer.io/), or with cloud ecosystems like OpenStack, MS Azure, or AWS.
  - Some of these cloud services [directly integrate](https://www.docker.com/partners) with Docker.

- Cross-platform compatibility
  - Because they include the OS, they can be deployed on a totally dissimilar system from your dev environment - even with non-cross-platform apps. (Norman will describe how to consume a Docker image in his part of this talk.)
  - Docker can run on any hardware from ARM 64 platforms like the Raspberry Pi to cloud clusters, enabling painless migration to other OS's.
    - Give yourself an out when your host OS is discontinued. (Running on CentOS vs Docker within CentOS)
    - Protect yourself against vendor lock-in. (Contractual difficulties with cloud hosting providers - Parler app).

- Security
  - In the hands of the image publisher. You select the OS environment for your app.
  - You update when you want to, after careful testing. The burden of ensuring compatibility between the App, its Dependencies, and the OS is now on the Developers rather than the unsuspecting Sysadmin. Remove the 'Oh, no!' moments when an OS update breaks live systems on the field.
  - Use [`docker scan`](https://docs.docker.com/engine/scan/) to check your local images.

- Light-weight Compartmentalization with external visibility
  - Forces sysadmins to properly deal with the separation of data from the app (backups).
  - Exploits in your app (or a sibling container) won't take down the host.
  - Unlike a full virtualization platform, you can still see into the container images from the host.

### III. Some specific use-cases for Docker:
- Flexible development toolchains (Gitea, Seq)
- "Throw-away" build environments (CI/CD pipelines)
- Portable and scalable testing environments.
- "One-click", pre-configured software installs.

### IV. Basic Docker Components
Here's the high-level difference between `docker` commands, `.dockerfile`, and Docker Compose:
- `docker` commands are for manually building images and running containers
- `.dockerfile` is the script used to build docker images from the contents of a given directory.
- `.docker-compose.yml` files are scripts that automate the tasks you can do manually with `docker` commands.
  - They're not a one-to-one correlation to `docker` commands.
  - Often used to manage clusters of dependent images. (The cloud platforms mentioned earlier would rely on Docker Compose.)

### V. Build Demo (for the Devs)
I. Build on SG's dev PC
- `docker build` from existing binaries
- Volume declaration
- Environment variables
- Spin up app.

II. Build from local Git repository
- `docker build` with Git repo path
- Image will `dotnet restore` and build code.
- Note: Be sure to clean up source when done.
- Image will run resulting binaries
