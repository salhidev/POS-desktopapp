USE [FBA]
GO
/****** Objet :  View [dbo].[V_Rayon]    Date de génération du script : 05/25/2012 08:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Rayon]
AS
SELECT     dbo.RAYON.RAY_LIB AS [Libellé du rayon], dbo.FAMILLE.FML_LIB AS [Libellé du famille], dbo.SOUS_FAMILLE.SF_LIB AS [Libellé du sous-famille], 
                      dbo.MARQUE.MRQ_LIB AS [Libellé de la marque]
FROM         dbo.FAMILLE INNER JOIN
                      dbo.RAYON ON dbo.FAMILLE.RAY_ID = dbo.RAYON.RAY_ID INNER JOIN
                      dbo.SOUS_FAMILLE ON dbo.FAMILLE.FML_ID = dbo.SOUS_FAMILLE.FML_ID INNER JOIN
                      dbo.MARQUE ON dbo.SOUS_FAMILLE.SF_ID = dbo.MARQUE.SF_ID

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[21] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "FAMILLE"
            Begin Extent = 
               Top = 3
               Left = 249
               Bottom = 103
               Right = 441
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MARQUE"
            Begin Extent = 
               Top = 117
               Left = 266
               Bottom = 217
               Right = 458
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RAYON"
            Begin Extent = 
               Top = 14
               Left = 15
               Bottom = 99
               Right = 207
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SOUS_FAMILLE"
            Begin Extent = 
               Top = 0
               Left = 508
               Bottom = 100
               Right = 700
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
  ' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'VIEW', @level1name=N'V_Rayon'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' End
End
' ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'VIEW', @level1name=N'V_Rayon'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 ,@level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'VIEW', @level1name=N'V_Rayon'
