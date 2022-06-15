-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 25/05/2022 às 16:38
-- Versão do servidor: 10.4.21-MariaDB
-- Versão do PHP: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `sistema_gerenciador_escolar`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_alunos`
--

CREATE TABLE `tb_alunos` (
  `id_aluno` int(11) NOT NULL,
  `nome_aluno` varchar(80) NOT NULL,
  `endereco_aluno` varchar(100) NOT NULL,
  `complemento_aluno` varchar(100) NOT NULL,
  `bairro_aluno` varchar(100) NOT NULL,
  `cep_aluno` varchar(10) NOT NULL,
  `cidade_aluno` varchar(100) NOT NULL,
  `uf_aluno` varchar(2) NOT NULL,
  `email_aluno` varchar(80) NOT NULL,
  `datanasc_aluno` date NOT NULL,
  `cpf_aluno` varchar(12) NOT NULL,
  `rg_aluno` varchar(12) NOT NULL,
  `tituloEleitor_aluno` varchar(20) NOT NULL,
  `sexo_aluno` varchar(9) NOT NULL,
  `nomePai_aluno` varchar(100) NOT NULL,
  `nomeMae_aluno` varchar(100) NOT NULL,
  `foto_aluno` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_usuarios`
--

CREATE TABLE `tb_usuarios` (
  `id_usuario` int(11) NOT NULL,
  `usuario` varchar(100) NOT NULL,
  `senha` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`id_usuario`, `usuario`, `senha`) VALUES
(1, 'Cesarrt@gmail.com', '123a456'),
(2, '', ''),
(3, 'cesar@', '123456');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `tb_alunos`
--
ALTER TABLE `tb_alunos`
  ADD PRIMARY KEY (`id_aluno`);

--
-- Índices de tabela `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_alunos`
--
ALTER TABLE `tb_alunos`
  MODIFY `id_aluno` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
