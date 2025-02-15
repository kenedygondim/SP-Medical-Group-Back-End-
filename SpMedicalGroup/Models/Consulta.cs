﻿namespace SpMedicalGroup.Models
{
    public class Consulta
    {
        public int ConsultaId { get; set; }
        public required int DisponibilidadeId { get; set; }
        public required int EspecialidadeId { get; set; }
        public required string Descricao { get; set; }
        public required string Situacao { get; set; }
        public required string CpfPaciente { get; set; }
        public required bool IsTelemedicina { get; set; }
    }
}
