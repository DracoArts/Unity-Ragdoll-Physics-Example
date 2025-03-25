
# Welcome to DracoArts

![Logo](https://dracoarts-logo.s3.eu-north-1.amazonaws.com/DracoArts.png)




#  Unity Ragdoll Physics System 

  A ragdoll physics system is a procedural animation technique used in games and simulations to make character movement more realistic when reacting to forces, impacts, or death. Instead of using pre-made animations, ragdoll physics relies on real-time physics calculations to determine how a character's body should collapse, fall, or react to external forces.

## Setting Up a Ragdoll
 - Create a Ragdoll:

- Select your character GameObject

- Go to Component → Physics → Ragdoll

- Configure the ragdoll by assigning bones to each body part

- Click "Create" to generate the ragdoll colliders and joints.
## 🔹 How Ragdoll Physics Works
- A ragdoll system consists of:

- Rigidbodies – Simulate mass and physics for each body part (head, arms, legs, etc.).

- Colliders – Define the physical shape of each body part (capsules, boxes, or spheres).

- Joints (CharacterJoint/ConfigurableJoint in Unity) – Connect body parts with constraints to mimic real skeletal movement.

- Animator Disabling – When ragdoll is active, the regular animation system is turned off, letting physics take over.
## Example Use Cases 

- Death animations (more realistic than scripted animations)

- Reaction to explosions or bullet impacts

- Dynamic falling (e.g., from heights or being hit by vehicles)

- Stumbling, tripping, or knockback effects

#     Key Features of a Good Ragdoll System

- Activation/Deactivation	
     Switch between animation and physics control


- Collision Detection
	  Allows body parts to interact with the environment
- Joint Limits	
     Prevents unnatural bending (e.g., knees bending backward)
- Force Application
	Lets you push, pull, or explode body parts
- Blending with Animations
	Smooth transition between ragdoll and animated states
# Advantages of Ragdoll Physics
 ## ✅ More Realistic Movement 
 No canned animations; physics reacts naturally.
## ✅ Dynamic Reactions 
 Different forces produce unique results.
## ✅ Immersion 
 Makes death and injuries look believable.
## ✅ Less Animation Work 
 No need to hand-animate every possible fall.



## Usage/Examples
    [SerializeField]
    private Animator Animator;
    [SerializeField]
    private Transform RagdollRoot;
    [SerializeField]
    private bool StartRagdoll = false;
    // Only public for Ragdoll Runtime GUI for explosive force
    public Rigidbody[] Rigidbodies;
    private CharacterJoint[] Joints;
    private Collider[] Colliders;

    private void Awake()
    {
        Rigidbodies = RagdollRoot.GetComponentsInChildren<Rigidbody>();
        Joints = RagdollRoot.GetComponentsInChildren<CharacterJoint>();
        Colliders = RagdollRoot.GetComponentsInChildren<Collider>();

        if (StartRagdoll)
        {
            EnableRagdoll();
        }
        else
        {
            EnableAnimator();
        }
    }

    public void EnableRagdoll()
    {
        Animator.enabled = false;
        foreach (CharacterJoint joint in Joints)
        {
            joint.enableCollision = true;
        }
        foreach (Collider collider in Colliders)
        {
            collider.enabled = true;
        }
        foreach (Rigidbody rigidbody in Rigidbodies)
        {
            rigidbody.velocity = Vector3.zero;
            rigidbody.detectCollisions = true;
            rigidbody.useGravity = true;
        }
    }

    public void EnableAnimator()
    {
        Animator.enabled = true;
        foreach (CharacterJoint joint in Joints)
        {
            joint.enableCollision = false;
        }
        foreach (Collider collider in Colliders)
        {
            collider.enabled = false;
        }
        foreach (Rigidbody rigidbody in Rigidbodies)
        {
            rigidbody.detectCollisions = false;
            rigidbody.useGravity = false;
        }
    }

## Images

![](https://raw.githubusercontent.com/AzharKhemta/DemoClient/refs/heads/main/ragdoll.gif)

## Authors

- [@MirHamzaHasan](https://github.com/MirHamzaHasan)
- [@WebSite](https://mirhamzahasan.com)


## 🔗 Links

[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/company/mir-hamza-hasan/posts/?feedView=all/)
## Tech Stack
**Client:** Unity,C#

**Package:** Ragdoll




## Documentation

[Documentation](https://docs.unity3d.com/Manual/wizard-RagdollWizard.htmll)

