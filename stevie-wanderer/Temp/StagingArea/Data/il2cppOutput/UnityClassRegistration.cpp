struct ClassRegistrationContext;
void InvokeRegisterStaticallyLinkedModuleClasses(ClassRegistrationContext& context)
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

}

void RegisterAllClasses()
{
	//Total: 78 classes
	//0. AssetBundle
	void RegisterClass_AssetBundle();
	RegisterClass_AssetBundle();

	//1. NamedObject
	void RegisterClass_NamedObject();
	RegisterClass_NamedObject();

	//2. EditorExtension
	void RegisterClass_EditorExtension();
	RegisterClass_EditorExtension();

	//3. RenderSettings
	void RegisterClass_RenderSettings();
	RegisterClass_RenderSettings();

	//4. LevelGameManager
	void RegisterClass_LevelGameManager();
	RegisterClass_LevelGameManager();

	//5. GameManager
	void RegisterClass_GameManager();
	RegisterClass_GameManager();

	//6. QualitySettings
	void RegisterClass_QualitySettings();
	RegisterClass_QualitySettings();

	//7. GlobalGameManager
	void RegisterClass_GlobalGameManager();
	RegisterClass_GlobalGameManager();

	//8. Mesh
	void RegisterClass_Mesh();
	RegisterClass_Mesh();

	//9. Renderer
	void RegisterClass_Renderer();
	RegisterClass_Renderer();

	//10. Component
	void RegisterClass_Component();
	RegisterClass_Component();

	//11. GUILayer
	void RegisterClass_GUILayer();
	RegisterClass_GUILayer();

	//12. Behaviour
	void RegisterClass_Behaviour();
	RegisterClass_Behaviour();

	//13. Texture
	void RegisterClass_Texture();
	RegisterClass_Texture();

	//14. Texture2D
	void RegisterClass_Texture2D();
	RegisterClass_Texture2D();

	//15. Texture3D
	void RegisterClass_Texture3D();
	RegisterClass_Texture3D();

	//16. RenderTexture
	void RegisterClass_RenderTexture();
	RegisterClass_RenderTexture();

	//17. RectTransform
	void RegisterClass_RectTransform();
	RegisterClass_RectTransform();

	//18. Transform
	void RegisterClass_Transform();
	RegisterClass_Transform();

	//19. Shader
	void RegisterClass_Shader();
	RegisterClass_Shader();

	//20. TextAsset
	void RegisterClass_TextAsset();
	RegisterClass_TextAsset();

	//21. Material
	void RegisterClass_Material();
	RegisterClass_Material();

	//22. Sprite
	void RegisterClass_Sprite();
	RegisterClass_Sprite();

	//23. Camera
	void RegisterClass_Camera();
	RegisterClass_Camera();

	//24. MonoBehaviour
	void RegisterClass_MonoBehaviour();
	RegisterClass_MonoBehaviour();

	//25. GameObject
	void RegisterClass_GameObject();
	RegisterClass_GameObject();

	//26. Rigidbody
	void RegisterClass_Rigidbody();
	RegisterClass_Rigidbody();

	//27. Collider
	void RegisterClass_Collider();
	RegisterClass_Collider();

	//28. Collider2D
	void RegisterClass_Collider2D();
	RegisterClass_Collider2D();

	//29. AudioClip
	void RegisterClass_AudioClip();
	RegisterClass_AudioClip();

	//30. SampleClip
	void RegisterClass_SampleClip();
	RegisterClass_SampleClip();

	//31. AudioListener
	void RegisterClass_AudioListener();
	RegisterClass_AudioListener();

	//32. AudioBehaviour
	void RegisterClass_AudioBehaviour();
	RegisterClass_AudioBehaviour();

	//33. AudioSource
	void RegisterClass_AudioSource();
	RegisterClass_AudioSource();

	//34. Animator
	void RegisterClass_Animator();
	RegisterClass_Animator();

	//35. DirectorPlayer
	void RegisterClass_DirectorPlayer();
	RegisterClass_DirectorPlayer();

	//36. Font
	void RegisterClass_Font();
	RegisterClass_Font();

	//37. Canvas
	void RegisterClass_Canvas();
	RegisterClass_Canvas();

	//38. CanvasGroup
	void RegisterClass_CanvasGroup();
	RegisterClass_CanvasGroup();

	//39. CanvasRenderer
	void RegisterClass_CanvasRenderer();
	RegisterClass_CanvasRenderer();

	//40. SpriteRenderer
	void RegisterClass_SpriteRenderer();
	RegisterClass_SpriteRenderer();

	//41. RuntimeAnimatorController
	void RegisterClass_RuntimeAnimatorController();
	RegisterClass_RuntimeAnimatorController();

	//42. PreloadData
	void RegisterClass_PreloadData();
	RegisterClass_PreloadData();

	//43. Cubemap
	void RegisterClass_Cubemap();
	RegisterClass_Cubemap();

	//44. TimeManager
	void RegisterClass_TimeManager();
	RegisterClass_TimeManager();

	//45. AudioManager
	void RegisterClass_AudioManager();
	RegisterClass_AudioManager();

	//46. InputManager
	void RegisterClass_InputManager();
	RegisterClass_InputManager();

	//47. Physics2DSettings
	void RegisterClass_Physics2DSettings();
	RegisterClass_Physics2DSettings();

	//48. MeshRenderer
	void RegisterClass_MeshRenderer();
	RegisterClass_MeshRenderer();

	//49. GraphicsSettings
	void RegisterClass_GraphicsSettings();
	RegisterClass_GraphicsSettings();

	//50. MeshFilter
	void RegisterClass_MeshFilter();
	RegisterClass_MeshFilter();

	//51. PhysicsManager
	void RegisterClass_PhysicsManager();
	RegisterClass_PhysicsManager();

	//52. Joint
	void RegisterClass_Joint();
	RegisterClass_Joint();

	//53. BoxCollider
	void RegisterClass_BoxCollider();
	RegisterClass_BoxCollider();

	//54. AnimationClip
	void RegisterClass_AnimationClip();
	RegisterClass_AnimationClip();

	//55. Motion
	void RegisterClass_Motion();
	RegisterClass_Motion();

	//56. TagManager
	void RegisterClass_TagManager();
	RegisterClass_TagManager();

	//57. Avatar
	void RegisterClass_Avatar();
	RegisterClass_Avatar();

	//58. AnimatorController
	void RegisterClass_AnimatorController();
	RegisterClass_AnimatorController();

	//59. ScriptMapper
	void RegisterClass_ScriptMapper();
	RegisterClass_ScriptMapper();

	//60. DelayedCallManager
	void RegisterClass_DelayedCallManager();
	RegisterClass_DelayedCallManager();

	//61. Light
	void RegisterClass_Light();
	RegisterClass_Light();

	//62. MonoScript
	void RegisterClass_MonoScript();
	RegisterClass_MonoScript();

	//63. MonoManager
	void RegisterClass_MonoManager();
	RegisterClass_MonoManager();

	//64. FlareLayer
	void RegisterClass_FlareLayer();
	RegisterClass_FlareLayer();

	//65. PlayerSettings
	void RegisterClass_PlayerSettings();
	RegisterClass_PlayerSettings();

	//66. SphereCollider
	void RegisterClass_SphereCollider();
	RegisterClass_SphereCollider();

	//67. CapsuleCollider
	void RegisterClass_CapsuleCollider();
	RegisterClass_CapsuleCollider();

	//68. SkinnedMeshRenderer
	void RegisterClass_SkinnedMeshRenderer();
	RegisterClass_SkinnedMeshRenderer();

	//69. FixedJoint
	void RegisterClass_FixedJoint();
	RegisterClass_FixedJoint();

	//70. BuildSettings
	void RegisterClass_BuildSettings();
	RegisterClass_BuildSettings();

	//71. CharacterJoint
	void RegisterClass_CharacterJoint();
	RegisterClass_CharacterJoint();

	//72. SpringJoint
	void RegisterClass_SpringJoint();
	RegisterClass_SpringJoint();

	//73. ResourceManager
	void RegisterClass_ResourceManager();
	RegisterClass_ResourceManager();

	//74. ConfigurableJoint
	void RegisterClass_ConfigurableJoint();
	RegisterClass_ConfigurableJoint();

	//75. LightmapSettings
	void RegisterClass_LightmapSettings();
	RegisterClass_LightmapSettings();

	//76. LightProbes
	void RegisterClass_LightProbes();
	RegisterClass_LightProbes();

	//77. RuntimeInitializeOnLoadManager
	void RegisterClass_RuntimeInitializeOnLoadManager();
	RegisterClass_RuntimeInitializeOnLoadManager();

}
