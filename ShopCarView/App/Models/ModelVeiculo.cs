﻿namespace ShopCar.App.Models;
public class ModelVeiculo
{
	public int Id { get; set; }
	public string? Placa { get; set; }
	public string? Chassi { get; set; }
	public string? Marca { get; set; }
	public string? NomeMarca { get; set; }
	public string? Modelo { get; set; }
	public string? NomeModelo { get; set; }
	public int AnoFabricacao { get; set; }
	public int AnoModelo { get; set; }
	public decimal ValorFipe { get; set; }
	public decimal ValorVenda { get; set; }
	public string? Observacoes { get; set; }
}

