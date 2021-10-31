using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    public static VolumeValue inst;

    public GameObject BGMusic;  //��� ������ � ������� �������
    private AudioSource audioSrc;
    public static float musicVolume;
    public Slider VolValue; //������� ���� ����� �����������
    public GameObject[] objs1;

    private void Awake()
    {
        inst = this;
        //VolValue = GameObject.FindObjectOfType("Slaider");
        objs1 = GameObject.FindGameObjectsWithTag("Sound"); //�� �������� ������ ��� Sound ��� ������� � �������
        if (objs1.Length == 0)
        {
            BGMusic = Instantiate(BGMusic); //������� ������ �� �������
            BGMusic.name = "BGMusic";  //�������������, ������ ������� ��� ��������:)
            DontDestroyOnLoad(BGMusic.gameObject); //����� �� ��� ������
        }
        else
            BGMusic = GameObject.Find("BGMusic"); //���������� � �������, ���� �� ��� ����������.
        
        if (!PlayerPrefs.HasKey("MusicVol"))
            musicVolume = 0.1f;  //��� ��������� �� ���������
        else
        {
            musicVolume = PlayerPrefs.GetFloat("MusicVol"); //����������� ���������
            VolValue.value = PlayerPrefs.GetFloat("MusicVol"); //������ �������� �������� �� ����������� ���������
        }
    }
    private void Start()
    {
        audioSrc = BGMusic.GetComponent<AudioSource>();
    }

    private void Update()
    {
        audioSrc.volume = musicVolume;  //������������� ��������� ��� ��������� ��������
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
        PlayerPrefs.SetFloat("MusicVol", vol); //��������� ���������
    }

    public void StopMusic()
    {
        audioSrc.Play();
    }

    public void PlayMusic()
    {
        audioSrc.Pause();
    }
}