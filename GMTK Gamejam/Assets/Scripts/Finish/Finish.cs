using UnityEngine;

public class Finish : MonoBehaviour
{
	public delegate void FinishHandler();
	public event FinishHandler FinishEvent;

	[SerializeField] private LayerMask _layerMask;

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (_layerMask == (_layerMask | (1 << col.gameObject.layer)))
		{
			if (FinishEvent != null)
				FinishEvent();
		}
	}
}