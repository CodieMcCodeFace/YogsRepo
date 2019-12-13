using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField]
    private UIManager _uiManager;
    [SerializeField]
    private float _playerHealth = 3;
    [SerializeField]
    private bool _presentHeld = true;
    [SerializeField]
    private GameObject _respawnLocation;
    [SerializeField]
    private int _playerID = 1;
    [SerializeField]
    private float _movementSpeed = 15f;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        _uiManager.UpdateHealth(_playerID, _playerHealth);
        Respawn();
    }
    void Respawn()
    {

    }
    void Update()
    {
        CalculateMovement();
    }
    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        Vector3 velocity = new Vector3(direction.x, direction.y, 0);
        _controller.Move(velocity * _movementSpeed * Time.deltaTime);
    }
}
